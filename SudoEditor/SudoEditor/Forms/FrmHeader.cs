using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudoEditor
{
    public partial class FrmHeader : Form
    {
        public FrmHeader()
        {
            InitializeComponent();
        }

        private Room room;
        private bool NoChanges;

        private void FrmHeader_Load(object sender, EventArgs e)
        {
            room = SudoEditor.CurrentRoom;
            FillInfo();
            foreach (Area area in Area.Areas) cbZone.Items.Add(area.Nom);
            cbZone.SelectedIndex = room.AreaID;
            UpdateCBSalle();
            cbSalle.SelectedIndex = room.ID;
        }

        private void btnAfficherT_Click(object sender, EventArgs e)
        {
            try
            {
                ImageView.Image = SudoEditor.Tilesets[int.Parse(tbTileset.Text)];
                ImageView.Image.Tag = $"Tileset {tbTileset.Text}";
                ImageView image = new ImageView();
                image.Show();
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Le tileset spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (FormatException)
            {
                MessageBox.Show("La donnée fournie pour le tileset est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAfficherB_Click(object sender, EventArgs e)
        {
            try
            {
                ImageView.Image = SudoEditor.Backgrounds[int.Parse(tbBG0.Text)];
                ImageView.Image.Tag = $"Background {tbBG0.Text}";
                ImageView image = new ImageView();
                image.Show();
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Le background spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (FormatException)
            {
                MessageBox.Show("La donnée fournie pour le background est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tbTileset_TextChanged(object sender, EventArgs e)
        {
            btnAfficherT.Enabled = tbTileset.Text != "";
            btnAppliquer.Enabled = true;
        }

        private void tbBG0_TextChanged(object sender, EventArgs e)
        {
            btnAfficherB.Enabled = tbBG0.Text != "";
            btnAppliquer.Enabled = true;
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            bool tilesetT = false;
            try { foreach (int id in SudoEditor.Tilesets.Keys) if (id == int.Parse(tbTileset.Text)) { tilesetT = true; break; } }
            catch
            {
                MessageBox.Show("La donnée fournie pour le tileset est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!tilesetT)
            {
                MessageBox.Show("Le tileset spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            bool backgroundT = false;
            try { foreach (int id in SudoEditor.Backgrounds.Keys) if (id == int.Parse(tbBG0.Text)) { backgroundT = true; break; } }
            catch
            {
                MessageBox.Show("La donnée fournie pour le background est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!backgroundT)
            {
                MessageBox.Show("Le background spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            try
            {
                if (double.Parse(tbTransparency.Text) < 0 || double.Parse(tbTransparency.Text) > 1)
                { 
                    MessageBox.Show("La transparence doit être comprise entre 0 et 1 (inclus)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("La donnée fournie pour la transparence est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            int? MapX = null;
            int? MapY = null;
            double? ScrollX = null;
            double? ScrollY = null;
            try
            {
                MapX = int.Parse(tbMapX.Text);
                MapY = int.Parse(tbMapY.Text);
                ScrollX = double.Parse(tbScrollX.Text);
                ScrollY = double.Parse(tbScrollY.Text);
            }
            catch
            {
                if (MapX == null) MessageBox.Show("La donnée fournie pour le X de la minimap est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (MapY == null) MessageBox.Show("La donnée fournie pour le Y de la minimap est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (ScrollX == null) MessageBox.Show("La donnée fournie pour le X du scrolling est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (ScrollY == null) MessageBox.Show("La donnée fournie pour le Y du scrolling est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            bool IsCurrentRoom = SudoEditor.CurrentRoom == room;

            Header h = Header.New;
            h.TilesetNbr = int.Parse(tbTileset.Text);
            h.BG0Nbr = int.Parse(tbBG0.Text);
            h.Transparency = double.Parse(tbTransparency.Text);
            h.MapX = (int)MapX;
            h.MapY = (int)MapY;
            h.MusicNbr = int.Parse(tbMusic.Text);
            h.HorizontalScroll = (double)ScrollX;
            h.VerticalScroll = (double)ScrollY;

            if (IsCurrentRoom)
            {
                SudoEditor.CurrentRoom.Header = h;
                SudoEditor.UpdateRoom();
            }
            else
            {
                Area.Areas[cbZone.SelectedIndex].Rooms[cbSalle.SelectedIndex].Header = h;
            }
            btnAppliquer.Enabled = false;
        }

        private void tbTransparency_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMusic_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMapX_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMapY_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbScrollX_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbScrollY_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void UpdateCBSalle()
        {
            cbSalle.Items.Clear();
            for (int i = 0; i < Area.Areas[cbZone.SelectedIndex].Rooms.Count; i++) cbSalle.Items.Add(i);
        }

        private void btnFermer_Click(object sender, EventArgs e) => Close();

        private void cbSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = Area.Areas[cbZone.SelectedIndex].Rooms[cbSalle.SelectedIndex];
            FillInfo();
        }

        private void FillInfo()
        {
            tbTileset.Text = room.Header.TilesetNbr.ToString();
            tbBG0.Text = room.Header.BG0Nbr.ToString();
            tbTransparency.Text = room.Header.Transparency.ToString();
            tbMapX.Text = room.Header.MapX.ToString();
            tbMapY.Text = room.Header.MapY.ToString();
            tbMusic.Text = room.Header.MusicNbr.ToString();
            tbScrollX.Text = room.Header.HorizontalScroll.ToString();
            tbScrollY.Text = room.Header.VerticalScroll.ToString();
            NoChanges = true;
            btnAppliquer.Enabled = false;
        }

        private void btnAppliquer_EnabledChanged(object sender, EventArgs e)
        {
            if (!NoChanges) TSSSChanges.Text = "Modifications sauvegardées";
            else if (btnAppliquer.Enabled) { TSSSChanges.Text = "Modifications non sauvegardées"; NoChanges = false; }
            if (NoChanges) TSSSChanges.Text = "Aucune modification";
        }
    }
}