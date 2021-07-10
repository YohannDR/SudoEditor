using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Message;
using DiscordRPC.Logging;

namespace SudoEditor
{
    public partial class SudoEditor : Form
    {
        public SudoEditor()
        {
            InitializeComponent();
        }

        private static readonly DiscordRpcClient Client = new DiscordRpcClient("424087019149328395");

        private Point Pivot = new Point(-1, -1);
        private Point TileCursor = new Point(-1, -1);
        private Rectangle Selection = new Rectangle(-1, -1, 1, 1);

        private Bitmap SelectionImage;

        public static TileViewer Tileset = new TileViewer();
        public static RoomViewer RoomV = new RoomViewer();
        public static Room CurrentRoom;

        public static Projet Projet;
        public static bool isMouseInTileset;
        public static ComboBox cbZone;
        public static ComboBox cbSalle;
        public static ToolStripLabel TSSize;
        public static GroupBox gbTileset;


        private bool TileMode = true;
        private bool ObjectMode = false;

        public static List<string> Clipdatas = new List<string>();
        public static List<int> Musics = new List<int>();
        public static Dictionary<int, Image> Tilesets = new Dictionary<int, Image>();
        public static Dictionary<int, Image> Backgrounds = new Dictionary<int, Image>();

        public static readonly List<CheckBox> CBEdit = new List<CheckBox>();

        private void EnableUI()
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
            MSVue.Enabled = true;
            MSVueBG0.Checked = true;
            MSVueBG1.Checked = true;
            MSVueBG2.Checked = true;
            MSVueBG3.Checked = true;
            MSVueBG4.Checked = true;
            MSOptions.Enabled = true;

            TSEnregistrer.Enabled = true;
            TSEnregistrerSous.Enabled = true;
            TSTileMode.Enabled = true;
            TSTileMode.Checked = true;
            TSObjectMode.Enabled = true;
            TSHeader.Enabled = true;
            TSAjouter.Enabled = true;
            TSSupprimer.Enabled = true;
            TSClipboard.Enabled = true;

            int a = 0;
            foreach (string clip in Clipdatas) { cbCollission.Items.Add($"{a} - {clip}"); a++; }
            for (int i = 0; i < Area.Areas[0].Rooms.Count; i++) cbSalle.Items.Add(i);
            foreach (Area area in Area.Areas) cbZone.Items.Add(area.Nom);
            cbZone.SelectedIndex = 0;
            cbSalle.SelectedIndex = 0;
            cbCollission.SelectedIndex = 0;
            
            CurrentRoom = Area.Areas[0].Rooms[0];

            Controls.Add(Tileset);
            Tileset.BringToFront();
            gbTileset.Controls.Add(Tileset);
            Tileset.Location = new Point(15, 20);
            //Tileset.BackgroundImage = Tilesets[0];
            Tileset.BackgroundImage = Tilesets[CurrentRoom.Header.TilesetNbr];
            Tileset.MouseDown += new MouseEventHandler(Tileset_MouseDown);
            Tileset.MouseMove += new MouseEventHandler(Tileset_MouseMove);
            Tileset.MouseUp += new MouseEventHandler(Tileset_MouseUp);
            gbTileset.Size = new Size(gbTileset.Width, Tileset.BackgroundImage.Height + 35);
        }

        #region Tileset Events
        private void Tileset_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle SelRect = Tileset.SelRect;
            Tileset.ResizeSelection(new Rectangle(1, 1, 1, 1));
            Tileset.Invalidate(Union(SelRect, Tileset.SelRect));
            Tileset.Invalidate(Tileset.SelRect);
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                return;
            Pivot = TileCursor;
            Selection = new Rectangle(Pivot.X, Pivot.Y, 1, 1);
            Rectangle rectangle = new Rectangle(Pivot.X * 32, Pivot.Y * 32, 32, 32);
            Tileset.ResizeSelection(Selection);
            Tileset.Invalidate(rectangle);
            TSSize.Text = $"1 x 1";
        }


        private void Tileset_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> 5;
            int y = e.Y >> 5;
            if (x == TileCursor.X && y == TileCursor.Y || (x < 0 || x >= 8) || (y < 0 || y >= Tileset.Height / 32))
                return;
            TileCursor.X = x;
            TileCursor.Y = y;
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (!Tileset.HasSelection) return;
                Rectangle selRect = Tileset.SelRect;
                ResizeSelection(TileCursor);
                Tileset.ResizeSelection(Selection);
                Tileset.MoveRed(x, y);
                Tileset.Invalidate(Union(selRect, Tileset.SelRect));
                TSSize.Text = $"{Tileset.SelRect.Width / 32 + 1} x {Tileset.SelRect.Height / 32 + 1}";
            }
            else
            {
                Rectangle RedRect = Tileset.RedRect;
                Tileset.MoveRed(x, y);
                Tileset.Invalidate(Union(RedRect, Tileset.RedRect));
            }
        }

        private void Tileset_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right || !Tileset.HasSelection)
                return;
            Pivot = new Point(-1, -1);
            SelectionImage = new Bitmap(Tileset.SelRect.Width, Tileset.SelRect.Height);
            CopyBlocks();
        }

        #endregion

        public Rectangle Union(Rectangle rect1, Rectangle rect2)
        {
            int x = Math.Min(rect1.X, rect2.X);
            int y = Math.Min(rect1.Y, rect2.Y);
            int width = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width) - x + 1;
            int height = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height) - y + 1;
            return new Rectangle(x, y, width, height);
        }

        public void CopyBlocks()
        {
            /*if (Tileset.HasSelection)
            {
                Bitmap image = new Bitmap(Tileset.BackgroundImage);
                for (int x = 0; x < Tileset.SelRect.Width / 32; x++)
                {
                    for (int y = 0; y < Tileset.SelRect.Height / 32; y++) 
                    {
                        for (int a = 0; a < 32; a++)
                        {
                            for (int b = 0; b < 32; b++)
                            {
                                try { SelectionImage.SetPixel(y * 32 + a, x * 32 + b, image.GetPixel(Tileset.SelRect.X + a, Tileset.SelRect.Y + b)); }
                                catch { }
                            }
                        }
                    }
                }
            }
            else
            {
                //Tiles depuis le roomView
            }*/
        }

        private void ResizeSelection(Point pos)
        {
            int width = Math.Abs(pos.X - Pivot.X) + 1;
            int height = Math.Abs(pos.Y - Pivot.Y) + 1;
            Selection = new Rectangle(pos.X >= Pivot.X ? Pivot.X : pos.X, pos.Y >= Pivot.Y ? Pivot.Y : pos.Y, width, height);
        }

        private void DisbaleUI()
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
            MSVue.Enabled = false;
            MSOptions.Enabled = true;

            TSEnregistrer.Enabled = false;
            TSEnregistrerSous.Enabled = false;
            TSTileMode.Enabled = false;
            TSTileMode.Checked = false;
            TSObjectMode.Enabled = false;
            TSObjectMode.Checked = false;
            TSHeader.Enabled = false;
            TSAjouter.Enabled = false;
            TSSupprimer.Enabled = false;
            TSClipboard.Enabled = false;

            cbZone.Items.Clear();
            cbSalle.Items.Clear();
            cbCollission.Items.Clear();
        }

        private void ChangeMode()
        {
            TileMode = !TileMode;
            ObjectMode = !ObjectMode;
            TSTileMode.Checked = TileMode;
            TSObjectMode.Checked = ObjectMode;

            foreach (CheckBox cb in CBEdit) cb.Enabled = TileMode;
        }

        public static void UpdatePresence()
        {
            if (!Settings.DiscordRPC) return;
            if (Process.GetProcessesByName("Discord").Length == 0) return;
            if (!Client.IsInitialized)
                Client.Initialize();
            RichPresence RP = new RichPresence()
            {
                State = $"Editing room {cbSalle.SelectedIndex} of {Area.Areas[cbZone.SelectedIndex].Nom}",
                Assets = new Assets()
                {
                    LargeImageKey = "mzm.ico",
                    LargeImageText = "SudoEditor"
                },
                Timestamps = Timestamps.Now
            };
            Client.SetPresence(RP);
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

        private void FlushCBEdit(CheckBox cb)
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
            if (files.Length != 1) { MessageBox.Show("Veuillez drop un seul fichier à la fois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            string file = files[0];
            if (file.Substring(file.Length - 3, 3) != ".gp") { MessageBox.Show("Veuillez drop un ficheir .gp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
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
            MSVueBG1.Checked = cbVueBG1.Checked;
            if (TileMode) cbEditBG1.Enabled = cbVueBG1.Checked;
        }

        private void cbVueBG2_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG2.Checked = false;
            MSVueBG2.Checked = cbVueBG2.Checked;
            if (TileMode) cbEditBG2.Enabled = cbVueBG2.Checked;
        }

        private void cbVueBG3_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG3.Checked = false;
            MSVueBG3.Checked = cbVueBG3.Checked;
            if (TileMode) cbEditBG3.Enabled = cbVueBG3.Checked;
        }

        private void cbVueBG4_CheckedChanged(object sender, EventArgs e)
        {
            cbEditBG4.Checked = false;
            MSVueBG4.Checked = cbVueBG4.Checked;
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
            UpdateCBSalle(0);
        }

        private void TSAjouter_Click(object sender, EventArgs e) => new FrmAjout().Show();

        private void TSSupprimer_Click(object sender, EventArgs e) => new FrmSuppression().Show();

        private void TSAide_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous ouvrir le document d'aide ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Console.WriteLine("");
        }

        private void TSHeader_Click(object sender, EventArgs e) => new FrmHeader().Show();

        private void cbSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentRoom = Area.Areas[cbZone.SelectedIndex].Rooms[cbSalle.SelectedIndex];
            cbSalle.Refresh();
            UpdatePresence();
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

        private void SudoEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Client.Dispose();
        }

        private void MSOptionsDiscord_Click(object sender, EventArgs e)
        {
            Settings.DiscordRPC = !Settings.DiscordRPC;
            MSOptions.Checked = Settings.DiscordRPC;
        }

        private void TSClipboard_Click(object sender, EventArgs e)
        {
            if (SelectionImage != null) ImageView.Image = SelectionImage;
            else ImageView.Image = new Bitmap(1, 1);
            ImageView.Image.Tag = "Clipboard";
            ImageView image = new ImageView();
            image.Show();
        }

        private void MSVueClipboard_Click(object sender, EventArgs e) => TSClipboard_Click(1, new EventArgs());

        private void cbVueBG0_CheckedChanged(object sender, EventArgs e)
        {
            MSVueBG0.Checked = cbVueBG0.Checked;
        }

        private void MSVueBG0_Click(object sender, EventArgs e)
        {
            MSVueBG0.Checked = !MSVueBG0.Checked;
            cbVueBG0.Checked = MSVueBG0.Checked;
        }

        private void MSVueBG1_Click(object sender, EventArgs e)
        {
            MSVueBG1.Checked = !MSVueBG1.Checked;
            cbVueBG1.Checked = MSVueBG1.Checked;
        }

        private void MSVueBG2_Click(object sender, EventArgs e)
        {
            MSVueBG2.Checked = !MSVueBG2.Checked;
            cbVueBG2.Checked = MSVueBG2.Checked;
        }

        private void MSVueBG3_Click(object sender, EventArgs e)
        {
            MSVueBG3.Checked = !MSVueBG3.Checked;
            cbVueBG3.Checked = MSVueBG3.Checked;
        }

        private void MSVueBG4_Click(object sender, EventArgs e)
        {
            MSVueBG4.Checked = !MSVueBG4.Checked;
            cbVueBG4.Checked = MSVueBG4.Checked;
        }
    }
}