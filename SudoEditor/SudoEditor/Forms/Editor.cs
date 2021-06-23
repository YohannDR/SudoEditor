﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SudoEditor
{
    public partial class SudoEditor : Form
    {
        public SudoEditor()
        {
            InitializeComponent();
        }

        public static TileViewer Tileset = new TileViewer();
        public static RoomViewer RoomV = new RoomViewer();
        public static Room CurrentRoom;

        public static Projet Projet;
        public static bool isMouseInTileset;
        public static ComboBox cbZone;
        public static ComboBox cbSalle;
        public static ToolStripLabel TSSize;
        public static GroupBox gbTileset;


        bool TileMode = true;
        bool ObjectMode = false;

        public static List<string> Clipdatas = new List<string>();
        public static List<int> Musics = new List<int>();
        public static Dictionary<int, Image> Tilesets = new Dictionary<int, Image>();
        public static Dictionary<int, Image> Backgrounds = new Dictionary<int, Image>();

        public static readonly List<CheckBox> CBEdit = new List<CheckBox>();

        void EnableUI()
        {
            gbEmplacement.Visible = true;
            gbVue.Visible = true;
            gbEdit.Visible = true;
            gbCollision.Visible = true;
            gbTileset.Visible = true;
            gbSalle.Visible = true;

            MSProjetEnregistrer.Enabled = true;
            MSProjetEnregistrerSous.Enabled = true;
            MSProjetFermer.Enabled = true;

            TSEnregistrer.Enabled = true;
            TSEnregistrerSous.Enabled = true;
            TSTileMode.Enabled = true;
            TSTileMode.Checked = true;
            TSObjectMode.Enabled = true;
            TSHeader.Enabled = true;
            TSAjouter.Enabled = true;
            TSSupprimer.Enabled = true;

            Controls.Add(Tileset);
            Tileset.BringToFront();
            gbTileset.Controls.Add(Tileset);
            Tileset.Location = new Point(15, 20);
            Tileset.BackgroundImage = Tilesets[0];
            //Tileset.BackgroundImage = Tilesets[CurrentRoom.Header.TilesetNbr];
            gbTileset.Size = new Size(gbTileset.Width, Tileset.BackgroundImage.Height + 35);
            Tileset.Scroll.AutoScrollMinSize = new Size(256, Tileset.BackgroundImage.Height);

            int a = 0;
            foreach (string clip in Clipdatas) { cbCollission.Items.Add($"{a} - {clip}"); a++; }
            for (int i = 0; i < Area.Areas[0].Rooms.Count; i++) cbSalle.Items.Add(i);
            foreach (Area area in Area.Areas) cbZone.Items.Add(area.Nom);
            cbZone.SelectedIndex = 0;
            cbSalle.SelectedIndex = 0;
            cbCollission.SelectedIndex = 0;
            
            CurrentRoom = Area.Areas[0].Rooms[0];

            Refresh();
        }

        void DisbaleUI()
        {
            gbEmplacement.Visible = false;
            gbVue.Visible = false;
            gbEdit.Visible = false;
            gbCollision.Visible = false;
            gbTileset.Visible = false;
            gbSalle.Visible = false;

            MSProjetEnregistrer.Enabled = false;
            MSProjetEnregistrerSous.Enabled = false;
            MSProjetFermer.Enabled = false;

            TSEnregistrer.Enabled = false;
            TSEnregistrerSous.Enabled = false;
            TSTileMode.Enabled = false;
            TSTileMode.Checked = false;
            TSObjectMode.Enabled = false;
            TSObjectMode.Checked = false;
            TSHeader.Enabled = false;
            TSAjouter.Enabled = false;
            TSSupprimer.Enabled = false;

            cbZone.Items.Clear();
            cbSalle.Items.Clear();
            cbCollission.Items.Clear();
        }

        void ChangeMode()
        {
            TileMode = !TileMode;
            ObjectMode = !ObjectMode;
            TSTileMode.Checked = TileMode;
            TSObjectMode.Checked = ObjectMode;

            foreach (CheckBox cb in CBEdit) cb.Enabled = TileMode;
        }

        public static void UpdateCBSalle(int set = -1)
        {
            cbSalle.Items.Clear();
            for (int i = 0; i < Area.Areas[cbZone.SelectedIndex].Rooms.Count; i++) cbSalle.Items.Add(i);
            //cbSalle.SelectedIndex = 0;
            if (set != -1) cbSalle.SelectedIndex = set;
        }

        public static void UpdateCBZone(int set = -1)
        {
            cbZone.Items.Clear();
            foreach (Area area in Area.Areas) cbZone.Items.Add(area.Nom);
            if (set != -1) cbZone.SelectedIndex = set;
        }

        void FlushCBEdit(CheckBox cb)
        {
            if (!cb.Checked) return;
            foreach (CheckBox CB in CBEdit)
            {
                if (CB != cb && CB != cbEditClip) CB.Checked = false;
            }
        }



        public static void UpdateRoom()
        {
            Tileset.BackgroundImage = Tilesets[CurrentRoom.Header.TilesetNbr];
            //RoomV.BackgroundImage = Backgrounds[CurrentRoom.Header.BG0Nbr];

            gbTileset.Size = new Size(287, Tilesets[CurrentRoom.Header.TilesetNbr].Height + 40);
        }



        private void SudoEditor_DragEnter(object sender, DragEventArgs e) { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }

        private void SudoEditor_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length != 1) { MessageBox.Show("Veuillez drop un seul fichier à la fois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); return; }
            string file = files[0];
            if (file.Substring(file.Length - 3, 3) != ".gp") { MessageBox.Show("Veuillez drop un ficheir .gp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); return; }
            DisbaleUI();
            string[] path = file.Split("\\".ToCharArray()[0]);
            string absolutePath = path[0];
            for (int i = 1; i < path.Length - 1; i++) absolutePath += "\\" + path[i];
            Settings.GPFilePath = file;
            Settings.ProjectPath = absolutePath;
            Settings.RessourcesPath = absolutePath + "\\" + path[path.Length - 1].Substring(0, path.Length - 3) + " Ressources";
            Settings.AreaPath = Settings.RessourcesPath + "\\Areas\\";
            Projet = new Projet(false);
            Text = $"SudoEditor | {path[path.Length - 1].Substring(0, path.Length - 3)}";
            EnableUI();
        }

        private void MSProjetNouveau_Click(object sender, EventArgs e)
        {
            SaveFileDialog newProject = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Game Project Files | *.gp"
            };
            if (newProject.ShowDialog() != DialogResult.OK) return;
            DisbaleUI();
            StreamWriter gpFile = new StreamWriter(newProject.FileName, true, Encoding.ASCII, 12);
            gpFile.WriteLine("Game Project");
            string[] path = newProject.FileName.Split("\\".ToCharArray()[0]);
            string combinedPath = path[0];
            for (int i = 1; i < path.Length - 1; i++) combinedPath += "\\" + path[i];
            Settings.GPFilePath = newProject.FileName;
            Settings.ProjectPath = combinedPath;
            Settings.RessourcesPath = newProject.FileName.Substring(0, newProject.FileName.Length - 3) + " Ressources";
            Projet = new Projet(true);
            gpFile.Close();
            EnableUI();
        }

        private void MSProjetOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog project = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Game Project Files | *.gp",
                DefaultExt = ".gp"

            };
            if (project.ShowDialog() != DialogResult.OK) return;
            DisbaleUI();
            string[] path = project.FileName.Split("\\".ToCharArray()[0]);
            string absolutePath = path[0];
            for (int i = 1; i < path.Length - 1; i++) absolutePath += "\\" + path[i];
            Settings.GPFilePath = project.FileName;
            Settings.ProjectPath = absolutePath;
            Settings.RessourcesPath = absolutePath + "\\" + path[path.Length - 1].Substring(0, path.Length - 3) + " Ressources";
            Settings.AreaPath = Settings.RessourcesPath + "\\Areas\\";
            Projet = new Projet(false);
            Text = $"SudoEditor | {path[path.Length - 1].Substring(0, path.Length - 3)}";
            EnableUI();
        }

        private void MSProjetEnregistrer_Click(object sender, EventArgs e) => Projet.Save();

        private void MSProjetEnregistrerSous_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Game Project Files | *.gp"
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return;
            string[] path = saveFile.FileName.Split("\\".ToCharArray()[0]);
            string combinedPath = path[0];
            for (int i = 1; i < path.Length - 1; i++) combinedPath += "\\" + path[i];
            Settings.GPFilePath = saveFile.FileName;
            Settings.ProjectPath = combinedPath;
            Settings.RessourcesPath = saveFile.FileName.Substring(0, saveFile.FileName.Length - 3) + " Ressources";
        }

        private void MSProjetFermer_Click(object sender, EventArgs e)
        {
            DisbaleUI();
            Projet.Dispose();
        }

        private void cbVueBG1_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG1.Checked = false;
            if (TileMode) cbEditBG1.Enabled = cbVueBG1.Checked;
        }

        private void cbVueBG2_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG2.Checked = false;
            if (TileMode) cbEditBG2.Enabled = cbVueBG2.Checked;
        }

        private void cbVueBG3_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG3.Checked = false;
            if (TileMode) cbEditBG3.Enabled = cbVueBG3.Checked;
        }

        private void cbVueBG4_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG4.Checked = false;
            if (TileMode) cbEditBG4.Enabled = cbVueBG4.Checked;
        }

        private void TSOuvrir_Click(object sender, EventArgs e) => MSProjetOuvrir_Click(1, new EventArgs());

        private void TSEnregistrer_Click(object sender, EventArgs e) => Projet.Save();

        private void TSEnregistrerSous_Click(object sender, EventArgs e) => MSProjetEnregistrerSous_Click(1, new EventArgs());

        private void SudoEditor_Load(object sender, EventArgs e)
        {
            CBEdit.Add(cbEditBG1); CBEdit.Add(cbEditBG2); CBEdit.Add(cbEditBG3); CBEdit.Add(cbEditBG4); CBEdit.Add(cbEditClip);

            Controls.Add(cbZone);
            Controls.Add(cbSalle);

            gbTileset = new GroupBox
            {
                Location = new Point(22, 210),
                Margin = new Padding(4, 4, 4, 4),
                Name = "gbTileset",
                Padding = new Padding(4, 4, 4, 4),
                Size = new Size(287, 745),
                TabIndex = 10,
                TabStop = false,
                Text = "Tileset",
                Visible = false
            };
            Controls.Add(gbTileset);
            gbTileset.BringToFront();

            cbZone = new ComboBox
            {
                Name = "cbZone",
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Margin = new Padding(4),
                Location = new Point(49, 27),
                Size = new Size(100, 24)
            };
            cbZone.SelectedIndexChanged += cbZone_SelectedIndexChanged;
            cbZone.BringToFront();
            gbEmplacement.Controls.Add(cbZone);

            cbSalle = new ComboBox
            {
                Name = "cbSalle",
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Margin = new Padding(4),
                Location = new Point(49, 57),
                Size = new Size(100, 24)
            };
            cbSalle.SelectedIndexChanged += cbSalle_SelectedIndexChanged;
            cbSalle.BringToFront();
            gbEmplacement.Controls.Add(cbSalle);

            TSSize = new ToolStripLabel();
            toolStrip2.Items.Add(TSSize);
            TSSize.Name = "TSSize";
            TSSize.Size = new Size(40, 22);
            TSSize.Text = "0 x 0";

            Update();
        }

        private void TSTileMode_Click(object sender, EventArgs e) => ChangeMode();

        private void TSObjectMode_Click(object sender, EventArgs e) => ChangeMode();


        private void cbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCBSalle();
        }

        private void TSAjouter_Click(object sender, EventArgs e)
        {
            Ajout ajout = new Ajout();
            ajout.Show();
        }

        private void TSSupprimer_Click(object sender, EventArgs e)
        {
            Suppression suppr = new Suppression();
            suppr.Show();
        }

        private void TSAide_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous ouvrir le document d'aide ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Console.WriteLine("");
        }

        private void SudoEditor_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void TSHeader_Click(object sender, EventArgs e)
        {
            FrmHeader frm = new FrmHeader();
            frm.Show();
        }

        private void cbSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentRoom = Area.Areas[cbZone.SelectedIndex].Rooms[cbSalle.SelectedIndex];
            cbSalle.Refresh();
            UpdateRoom();
        }

        private void cbEditBG1_CheckedChanged(object sender, EventArgs e)
        {
            FlushCBEdit(cbEditBG1);
        }

        private void cbEditBG2_CheckedChanged(object sender, EventArgs e)
        {
            FlushCBEdit(cbEditBG2);
        }

        private void cbEditBG3_CheckedChanged(object sender, EventArgs e)
        {
            FlushCBEdit(cbEditBG3);
        }

        private void cbEditBG4_CheckedChanged(object sender, EventArgs e)
        {
            FlushCBEdit(cbEditBG4);
        }
    }
}