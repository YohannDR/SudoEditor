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

        Room room = SudoEditor.CurrentRoom;
        private void FrmHeader_Load(object sender, EventArgs e)
        {
            tbTileset.Text = room.Header.TilesetNbr.ToString();
            tbBG0.Text = room.Header.BG0Nbr.ToString();
            tbTransparency.Text = room.Header.Transparency.ToString();
            tbMapX.Text = room.Header.MapX.ToString();
            tbMapY.Text = room.Header.MapY.ToString();
            tbMusic.Text = room.Header.MusicNbr.ToString();
        }

        private void btnAfficherT_Click(object sender, EventArgs e)
        {
            try
            {
                Suppression.image = SudoEditor.Tilesets[int.Parse(tbTileset.Text)];
                Suppression.image.Tag = $"Tileset {tbTileset.Text}";
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
                Suppression.image = SudoEditor.Backgrounds[int.Parse(tbBG0.Text)];
                Suppression.image.Tag = $"Background {tbBG0.Text}";
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
            if (tbTileset.Text != "") btnAfficherT.Enabled = true;
            else btnAfficherT.Enabled = false;
        }

        private void tbBG0_TextChanged(object sender, EventArgs e)
        {
            if (tbBG0.Text != "") btnAfficherB.Enabled = true;
            else btnAfficherB.Enabled = false;
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
            room.Header.TilesetNbr = int.Parse(tbTileset.Text);
            room.Header.BG0Nbr = int.Parse(tbBG0.Text);
            room.Header.Transparency = double.Parse(tbTransparency.Text);
            room.Header.MapX = int.Parse(tbMapX.Text);
            room.Header.MapY = int.Parse(tbMapY.Text);
            room.Header.MusicNbr = int.Parse(tbMusic.Text);
            SudoEditor.CurrentRoom = room;
            SudoEditor.UpdateRoom();
        }
    }
}