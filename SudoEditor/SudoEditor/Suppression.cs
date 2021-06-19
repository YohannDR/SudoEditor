using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SudoEditor
{
    public partial class Suppression : Form
    {
        public Suppression()
        {
            InitializeComponent();
        }

        public static Image image;

        private void Suppression_Load(object sender, EventArgs e)
        {
            foreach (Area area in Area.Areas)
            {
                ListViewItem listViewItem = new ListViewItem();
                ListViewItem ligne = listViewItem;
                ligne.Text = area.Nom;
                ligne.SubItems.Add(area.Rooms.Count.ToString());
                lvZonesZ.Items.Add(ligne);
            }

            foreach (Area area in Area.Areas) cbZoneS.Items.Add(area.Nom);
            cbZoneS.SelectedIndex = 0;
            foreach (int id in SudoEditor.Tilesets.Keys) cbNumT.Items.Add(id);
            foreach (int id in SudoEditor.Backgrounds.Keys) cbNumB.Items.Add(id);
            pbPreviewT.BackColor = Color.FromArgb(40, 50, 50);
            pbPreviewB.BackColor = Color.FromArgb(40, 50, 50);
        }

        private void lvZonesZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZonesZ.SelectedItems.Count == 1) btnSupprZ.Enabled = true;
            else btnSupprZ.Enabled = false;
        }

        private void btnSupprZ_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Vous vous apprêtez à supprimer la zone {Area.Areas[lvZonesZ.SelectedIndices[0]].Nom}, êtes vous vraiment sur de vouloir faire ça ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Directory.Delete($"{Settings.RessourcesPath}/Areas/{Area.Areas[lvZonesZ.SelectedIndices[0]].Nom}", true);
                Area.Areas.Remove(Area.Areas[lvZonesZ.SelectedIndices[0]]);
                lvZonesZ.Items.Clear();
                foreach (Area area in Area.Areas)
                {
                    ListViewItem ligne = new ListViewItem { Text = area.Nom };
                    ligne.SubItems.Add(area.Rooms.Count.ToString());
                    lvZonesZ.Items.Add(ligne);
                }
                SudoEditor.UpdateCBZone(0);
                MessageBox.Show("La zone à été supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void cbZoneS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSalleS.Items.Clear();
            for (int i = 0; i < Area.Areas[cbZoneS.SelectedIndex].Rooms.Count; i++) cbSalleS.Items.Add(i);
            cbSalleS.SelectedIndex = 0;
        }

        private void btnSupprS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Vous vous apprêtez à supprimer la salle numéro {cbSalleS.Text} de la zone {cbZoneS.Text}, êtes vous vraiment sur de vouloir faire ça ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                File.Delete($"{Settings.RessourcesPath}/Areas/{cbZoneS.Text}/{cbSalleS.SelectedIndex}.room");
                for (int i = cbSalleS.SelectedIndex; i < Area.Areas[cbZoneS.SelectedIndex].Rooms.Count - 1; i++) File.Move($"{Settings.RessourcesPath}/Areas/{cbZoneS.Text}/{i + 1}.room", $"{Settings.RessourcesPath}/Areas/{cbZoneS.Text}/{i}.room");
                Area.Areas[cbZoneS.SelectedIndex].Rooms.Remove(Area.Areas[cbZoneS.SelectedIndex].Rooms[cbSalleS.SelectedIndex]);
                SudoEditor.UpdateCBSalle(0);
                cbSalleS.Items.Clear();
                for (int i = 0; i < Area.Areas[cbZoneS.SelectedIndex].Rooms.Count; i++) cbSalleS.Items.Add(i);
                cbSalleS.SelectedIndex = 0;
                MessageBox.Show("La salle à été supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void cbNumT_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPreviewT.Image = SudoEditor.Tilesets[int.Parse(cbNumT.Text)];
            btnImageFullT.Enabled = true;
        }

        private void btnImageFull_Click(object sender, EventArgs e)
        {
            image = SudoEditor.Tilesets[int.Parse(cbNumT.Text)];
            ImageView img = new ImageView();
            Suppression.image.Tag = $"Tileset {cbNumT.Text}";
            img.Show();
        }

        private void btnSupprimerT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Vous vous apprêtez à supprimer le tileset numéro {cbNumT.Text}, êtes vous vraiment sur de vouloir faire ça ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                SudoEditor.Tilesets.Remove(int.Parse(cbNumT.Text));
                File.Delete($"{Settings.RessourcesPath}/Tilesets/{cbNumT.Text}.png");
                /*foreach (Area area in Area.Areas)
                {
                    foreach (Room room in area.Rooms)
                    {
                        if (room.Header.TilesetNbr == int.Parse(cbNumT.Text)) room.Header.TilesetNbr = 0;
                    }
                }*/
                cbNumT.Items.Clear();
                foreach (int id in SudoEditor.Tilesets.Keys) cbNumT.Items.Add(id);
                pbPreviewT.Image = null;
                btnImageFullT.Enabled = false;
                MessageBox.Show("Le tileset à été supprimé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void cbNumB_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPreviewB.Image = SudoEditor.Backgrounds[int.Parse(cbNumB.Text)];
            btnImageFullB.Enabled = true;
        }

        private void btnImageFullB_Click(object sender, EventArgs e)
        {
            image = SudoEditor.Backgrounds[int.Parse(cbNumB.Text)];
            image.Tag = $"Background {cbNumB.Text}";
            ImageView img = new ImageView();
            img.Show();
        }
    }
}
