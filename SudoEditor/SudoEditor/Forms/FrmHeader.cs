using System;
using System.Drawing;
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

        Room room = SudoEditor.CurrentRoom;
        private void FrmHeader_Load(object sender, EventArgs e)
        {
            tbTileset.Text = room.Header.TilesetNbr.ToString();
            tbBG0.Text = room.Header.BG0Nbr.ToString();
            tbTransparency.Text = room.Header.Transparency.ToString();
            tbMapX.Text = room.Header.MapX.ToString();
            tbMapY.Text = room.Header.MapY.ToString();
            tbMusic.Text = room.Header.MusicNbr.ToString();
            btnAppliquer.Enabled = false;
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
                MessageBox.Show("Le tileset spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (FormatException)
            {
                MessageBox.Show("La donnée fournie pour le tileset est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                MessageBox.Show("Le background spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (FormatException)
            {
                MessageBox.Show("La donnée fournie pour le background est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                MessageBox.Show("La donnée fournie pour le tileset est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (!tilesetT)
            {
                MessageBox.Show("Le tileset spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            bool backgroundT = false;
            try { foreach (int id in SudoEditor.Backgrounds.Keys) if (id == int.Parse(tbBG0.Text)) { backgroundT = true; break; } }
            catch
            {
                MessageBox.Show("La donnée fournie pour le background est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (!backgroundT)
            {
                MessageBox.Show("Le background spécifié n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            try
            {
                if (double.Parse(tbTransparency.Text) < 0 || double.Parse(tbTransparency.Text) > 1)
                { 
                    MessageBox.Show("La transparence doit être comprise entre 0 et 1 (inclus)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("La donnée fournie pour la transparence est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            Header h = room.Header;
            h.TilesetNbr = int.Parse(tbTileset.Text);
            h.BG0Nbr = int.Parse(tbBG0.Text);
            h.Transparency = double.Parse(tbTransparency.Text);
            h.MapX = int.Parse(tbMapX.Text);
            h.MapY = int.Parse(tbMapY.Text);
            h.MusicNbr = int.Parse(tbMusic.Text);
            room.Header = h;
            SudoEditor.CurrentRoom = room;
            SudoEditor.UpdateRoom();
        }

        private void tbTransparency_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMusic_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMapX_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        private void tbMapY_TextChanged(object sender, EventArgs e) => btnAppliquer.Enabled = true;

        void UpdateCBSalle()
        {
            cbSalle.Items.Clear();
            for (int i = 0; i < Area.Areas[cbZone.SelectedIndex].Rooms.Count; i++) cbSalle.Items.Add(i);
        }
    }
}