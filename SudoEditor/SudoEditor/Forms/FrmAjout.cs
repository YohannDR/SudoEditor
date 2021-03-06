using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace SudoEditor
{
    public partial class FrmAjout : Form
    {
        public FrmAjout() => InitializeComponent();

        bool DefaultEvents = true;

        private void cbCopieS_CheckedChanged(object sender, EventArgs e)
        {
            gbCopieS.Enabled = cbCopieS.Checked;
        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog
            {
                Filter = "PNG Files | *.png",
                DefaultExt = ".png"
            };
            if (image.ShowDialog() != DialogResult.OK) return;
            tbImageT.Text = image.FileName;
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            foreach (Area area in Area.Areas) { cbZoneS.Items.Add(area.Nom); cbZoneCopieS.Items.Add(area.Nom); }
            cbZoneS.SelectedIndex = 0;
            cbZoneCopieS.SelectedIndex = 0;
            cbSalleCopieS.SelectedIndex = 0;
            foreach (Area area in Area.Areas) rtbZonesZ.Text += $"{area.Nom}\n";

            clbEvents.SetItemChecked(1, true);
            clbEvents.SetItemChecked(2, true);
        }

        private void btnAjoutZ_Click(object sender, EventArgs e)
        {
            if (tbNomZ.Text == "")
            {
                MessageBox.Show("Aucun nom de zone n'a été fourni", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            foreach (Area area in Area.Areas)
            {
                if (tbNomZ.Text == area.Nom)
                {
                    MessageBox.Show("Une zone avec ce nom existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            Area newArea;
            try
            {
                newArea = new Area(tbNomZ.Text, true, (int)nudNbrSalles.Value);
            }
            catch
            {
                MessageBox.Show("Le nom n'est pas un nom valable pour un dossier/fichier windows", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            MessageBox.Show($"Le zone {tbNomZ.Text} a été ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbNomZ.Text = "";
            nudNbrSalles.Value = 1;
            rtbZonesZ.Text = "";
            foreach (Area area in Area.Areas) rtbZonesZ.Text += $"{area.Nom}\n";
            SudoEditor.UpdateCBZone(newArea.ID);
        }

        private void btnAjouterS_Click(object sender, EventArgs e)
        {
            if (!cbCopieS.Checked)
            {
                Area.Areas[cbZoneS.SelectedIndex].AddRoom();
                MessageBox.Show("La salle a été ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SudoEditor.UpdateCBSalle(Area.Areas[cbZoneS.SelectedIndex].Rooms.Count - 1);
            }
            else
            {
                Area.Areas[cbZoneS.SelectedIndex].AddRoom();
                File.Delete(Settings.RessourcesPath + "/Areas/" + cbZoneS.Text + "/" + (Area.Areas[cbZoneS.SelectedIndex].Rooms.Count - 1) + ".room");
                File.Copy(Settings.RessourcesPath + "/Areas/" + cbZoneCopieS.Text + "/" + cbSalleCopieS.Text + ".room", Settings.RessourcesPath + "/Areas/" + cbZoneS.Text + "/" + (Area.Areas[cbZoneS.SelectedIndex].Rooms.Count - 1) + ".room");
                MessageBox.Show("La salle a été ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbZoneCopieS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSalleCopieS.Items.Clear();
            for (int i = 0; i < Area.Areas[cbZoneCopieS.SelectedIndex].Rooms.Count; i++) cbSalleCopieS.Items.Add(i);
            cbSalleCopieS.SelectedIndex = 0;
        }

        private void btnAjouterT_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbNumT.Text) < 0) throw new FormatException();

                Bitmap image = new Bitmap(tbImageT.Text);
                if (image.Width != 256 || image.Height % 32 != 0) throw new ArgumentException();

                File.Copy(tbImageT.Text, Settings.RessourcesPath + "/Tilesets/" + tbNumT.Text + ".png");
                MessageBox.Show("Le tileset à été ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SudoEditor.Tilesets.Add(int.Parse(tbNumT.Text), Image.FromFile(Settings.RessourcesPath + "/Tilesets/" + tbNumT.Text + ".png"));
                tbImageT.Text = "";
                tbNumT.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Le numéro de tileset n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbNumT.Text = "";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Les dimensions du tileset ne sont pas valides, il doit faire 256 de largueur et avoir une hauteur divisible par 32", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbImageT.Text = "";
            }
            catch (Exception E)
            {
                MessageBox.Show($"Une erreur inconnue s'est produite :\n{E.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnNumAutoT_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (int id in SudoEditor.Tilesets.Keys)
            {
                if (i != id)
                {
                    tbNumT.Text = i.ToString();
                    break;
                }
                i++;
            }
            tbNumT.Text = i.ToString();
        }

        private void btnImageFullT_Click(object sender, EventArgs e)
        {
            ImageView.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(tbImageT.Text)));
            ImageView.Image.Tag = $"Tileset {tbNumT.Text}";
            ImageView img = new ImageView();
            img.Show();
        }

        private void tbImageT_TextChanged(object sender, EventArgs e)
        {
            if (tbImageT.Text != "") { btnImageFullT.Enabled = true; btnAjouterT.Enabled = true; }
            else { btnImageFullT.Enabled = false; btnAjouterT.Enabled = false; }
        }

        private void btnImageSearchB_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog
            {
                Filter = "PNG Files | *.png",
                DefaultExt = ".png"
            };
            if (image.ShowDialog() != DialogResult.OK) return;
            tbImageB.Text = image.FileName;
        }

        private void btnNumAutoB_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (int id in SudoEditor.Backgrounds.Keys)
            {
                if (i != id)
                {
                    tbNumT.Text = i.ToString();
                    break;
                }
                i++;
            }
            tbNumB.Text = i.ToString();
        }

        private void tbImageB_TextChanged(object sender, EventArgs e)
        {
            if (tbImageB.Text != "") { btnImageFullB.Enabled = true; btnAjouterB.Enabled = true; }
            else { btnImageFullB.Enabled = false; btnAjouterB.Enabled = false; }
        }

        private void btnImageFullB_Click(object sender, EventArgs e)
        {
            ImageView.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(tbImageB.Text)));
            ImageView.Image.Tag = $"Background {tbNumB.Text}";
            ImageView img = new ImageView();
            img.Show();
        }

        private void btnAjouterB_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbNumB.Text) < 0) throw new Exception();
                File.Copy(tbImageB.Text, Settings.RessourcesPath + "/Backgrounds/" + tbNumB.Text + ".png");
                MessageBox.Show("Le background à été ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SudoEditor.Backgrounds.Add(int.Parse(tbNumB.Text), Image.FromFile(Settings.RessourcesPath + "/Backgrounds/" + tbNumB.Text + ".png"));
                tbImageB.Text = "";
                tbNumB.Text = "";
            }
            catch
            {
                MessageBox.Show("Le numéro de background n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbNumB.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog music = new OpenFileDialog
            {
                Filter = "MP3 Files | *.mp3",
                DefaultExt = ".mp3"
            };
            if (music.ShowDialog() != DialogResult.OK) return;
            tbMusic.Text = music.FileName;
        }

        private void tbSpriteAjouter_Click(object sender, EventArgs e)
        {
            string file = Settings.SpritePath + tbSpriteNom.Text + ".cs";
            SpriteEvents E;
            if (DefaultEvents)
                E = SpriteEvents.Default;
            else E = new SpriteEvents
                (clbEvents.GetItemChecked(0), clbEvents.GetItemChecked(1), clbEvents.GetItemChecked(2), clbEvents.GetItemChecked(3), clbEvents.GetItemChecked(4),
                clbEvents.GetItemChecked(5), clbEvents.GetItemChecked(6), clbEvents.GetItemChecked(7), clbEvents.GetItemChecked(8));

            File.WriteAllText(file, Settings.SpriteDefault(tbSpriteNom.Text, E));
            if (cbSpriteOuvrir.Checked) Process.Start(file);
        }

        private void btnSpriteDefault_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEvents.Items.Count; i++) clbEvents.SetItemChecked(i, i == 1 | i == 2 ? true : false);
            DefaultEvents = true;
        }

        private void clbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbEvents.CheckedItems.Count != 2) DefaultEvents = false;
            else DefaultEvents = clbEvents.GetItemChecked(1) & clbEvents.GetItemChecked(2);
        }

        private void tbSpriteNom_TextChanged(object sender, EventArgs e) => btnSpriteAjouter.Enabled = tbSpriteNom.Text != string.Empty;

        private void btnSpriteTout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEvents.Items.Count; i++) clbEvents.SetItemChecked(i, true);
        }

        private void btnSpriteToutD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEvents.Items.Count; i++) clbEvents.SetItemChecked(i, false);
        }
    }
}
