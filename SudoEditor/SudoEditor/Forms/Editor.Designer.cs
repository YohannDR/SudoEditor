
namespace SudoEditor
{
    partial class SudoEditor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudoEditor));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MSProjet = new System.Windows.Forms.ToolStripMenuItem();
            this.MSProjetNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MSProjetOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MSProjetEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.MSProjetEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MSProjetFermer = new System.Windows.Forms.ToolStripMenuItem();
            this.MSOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MSOptionsDiscord = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEmplacement = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVue = new System.Windows.Forms.GroupBox();
            this.cbVueBG4 = new System.Windows.Forms.CheckBox();
            this.cbVueBG3 = new System.Windows.Forms.CheckBox();
            this.cbVueBG2 = new System.Windows.Forms.CheckBox();
            this.cbVueBG1 = new System.Windows.Forms.CheckBox();
            this.cbVueBG0 = new System.Windows.Forms.CheckBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.cbEditBG4 = new System.Windows.Forms.CheckBox();
            this.cbEditBG3 = new System.Windows.Forms.CheckBox();
            this.cbEditBG2 = new System.Windows.Forms.CheckBox();
            this.cbEditBG1 = new System.Windows.Forms.CheckBox();
            this.cbEditClip = new System.Windows.Forms.CheckBox();
            this.gbCollision = new System.Windows.Forms.GroupBox();
            this.cbCollission = new System.Windows.Forms.ComboBox();
            this.gbSalle = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSOuvrir = new System.Windows.Forms.ToolStripButton();
            this.TSEnregistrer = new System.Windows.Forms.ToolStripButton();
            this.TSEnregistrerSous = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTileMode = new System.Windows.Forms.ToolStripButton();
            this.TSObjectMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSHeader = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSAjouter = new System.Windows.Forms.ToolStripButton();
            this.TSSupprimer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSAide = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TSClip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSClipboard = new System.Windows.Forms.ToolStripButton();
            this.MSVue = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVueBG0 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVueBG1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVueBG2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVueBG3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVueBG4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MSVueClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.gbEmplacement.SuspendLayout();
            this.gbVue.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.gbCollision.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSProjet,
            this.MSVue,
            this.MSOptions});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1443, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MSProjet
            // 
            this.MSProjet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSProjetNouveau,
            this.toolStripSeparator1,
            this.MSProjetOuvrir,
            this.MSProjetEnregistrer,
            this.MSProjetEnregistrerSous,
            this.toolStripSeparator2,
            this.MSProjetFermer});
            this.MSProjet.Name = "MSProjet";
            this.MSProjet.Size = new System.Drawing.Size(50, 20);
            this.MSProjet.Text = "Projet";
            // 
            // MSProjetNouveau
            // 
            this.MSProjetNouveau.Name = "MSProjetNouveau";
            this.MSProjetNouveau.Size = new System.Drawing.Size(180, 22);
            this.MSProjetNouveau.Text = "Nouveau";
            this.MSProjetNouveau.Click += new System.EventHandler(this.MSProjetNouveau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MSProjetOuvrir
            // 
            this.MSProjetOuvrir.Name = "MSProjetOuvrir";
            this.MSProjetOuvrir.Size = new System.Drawing.Size(180, 22);
            this.MSProjetOuvrir.Text = "Ouvrir";
            this.MSProjetOuvrir.Click += new System.EventHandler(this.MSProjetOuvrir_Click);
            // 
            // MSProjetEnregistrer
            // 
            this.MSProjetEnregistrer.Enabled = false;
            this.MSProjetEnregistrer.Name = "MSProjetEnregistrer";
            this.MSProjetEnregistrer.Size = new System.Drawing.Size(180, 22);
            this.MSProjetEnregistrer.Text = "Enregistrer";
            this.MSProjetEnregistrer.Click += new System.EventHandler(this.MSProjetEnregistrer_Click);
            // 
            // MSProjetEnregistrerSous
            // 
            this.MSProjetEnregistrerSous.Enabled = false;
            this.MSProjetEnregistrerSous.Name = "MSProjetEnregistrerSous";
            this.MSProjetEnregistrerSous.Size = new System.Drawing.Size(180, 22);
            this.MSProjetEnregistrerSous.Text = "Enregistrer sous...";
            this.MSProjetEnregistrerSous.Click += new System.EventHandler(this.MSProjetEnregistrerSous_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MSProjetFermer
            // 
            this.MSProjetFermer.Enabled = false;
            this.MSProjetFermer.Name = "MSProjetFermer";
            this.MSProjetFermer.Size = new System.Drawing.Size(180, 22);
            this.MSProjetFermer.Text = "Fermer";
            this.MSProjetFermer.Click += new System.EventHandler(this.MSProjetFermer_Click);
            // 
            // MSOptions
            // 
            this.MSOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSOptionsDiscord});
            this.MSOptions.Enabled = false;
            this.MSOptions.Name = "MSOptions";
            this.MSOptions.Size = new System.Drawing.Size(61, 20);
            this.MSOptions.Text = "Options";
            // 
            // MSOptionsDiscord
            // 
            this.MSOptionsDiscord.Name = "MSOptionsDiscord";
            this.MSOptionsDiscord.Size = new System.Drawing.Size(180, 22);
            this.MSOptionsDiscord.Text = "Discord Presence";
            this.MSOptionsDiscord.Click += new System.EventHandler(this.MSOptionsDiscord_Click);
            // 
            // gbEmplacement
            // 
            this.gbEmplacement.Controls.Add(this.label2);
            this.gbEmplacement.Controls.Add(this.label1);
            this.gbEmplacement.Location = new System.Drawing.Point(22, 56);
            this.gbEmplacement.Name = "gbEmplacement";
            this.gbEmplacement.Size = new System.Drawing.Size(157, 88);
            this.gbEmplacement.TabIndex = 1;
            this.gbEmplacement.TabStop = false;
            this.gbEmplacement.Text = "Emplacement";
            this.gbEmplacement.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zone : ";
            // 
            // gbVue
            // 
            this.gbVue.Controls.Add(this.cbVueBG4);
            this.gbVue.Controls.Add(this.cbVueBG3);
            this.gbVue.Controls.Add(this.cbVueBG2);
            this.gbVue.Controls.Add(this.cbVueBG1);
            this.gbVue.Controls.Add(this.cbVueBG0);
            this.gbVue.Location = new System.Drawing.Point(187, 56);
            this.gbVue.Name = "gbVue";
            this.gbVue.Size = new System.Drawing.Size(56, 145);
            this.gbVue.TabIndex = 2;
            this.gbVue.TabStop = false;
            this.gbVue.Text = "Vue";
            this.gbVue.Visible = false;
            // 
            // cbVueBG4
            // 
            this.cbVueBG4.AutoSize = true;
            this.cbVueBG4.Checked = true;
            this.cbVueBG4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueBG4.Location = new System.Drawing.Point(6, 117);
            this.cbVueBG4.Name = "cbVueBG4";
            this.cbVueBG4.Size = new System.Drawing.Size(47, 17);
            this.cbVueBG4.TabIndex = 8;
            this.cbVueBG4.Text = "BG4";
            this.cbVueBG4.UseVisualStyleBackColor = true;
            this.cbVueBG4.CheckedChanged += new System.EventHandler(this.cbVueBG4_CheckedChanged);
            // 
            // cbVueBG3
            // 
            this.cbVueBG3.AutoSize = true;
            this.cbVueBG3.Checked = true;
            this.cbVueBG3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueBG3.Location = new System.Drawing.Point(6, 94);
            this.cbVueBG3.Name = "cbVueBG3";
            this.cbVueBG3.Size = new System.Drawing.Size(47, 17);
            this.cbVueBG3.TabIndex = 7;
            this.cbVueBG3.Text = "BG3";
            this.cbVueBG3.UseVisualStyleBackColor = true;
            this.cbVueBG3.CheckedChanged += new System.EventHandler(this.cbVueBG3_CheckedChanged);
            // 
            // cbVueBG2
            // 
            this.cbVueBG2.AutoSize = true;
            this.cbVueBG2.Checked = true;
            this.cbVueBG2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueBG2.Location = new System.Drawing.Point(6, 71);
            this.cbVueBG2.Name = "cbVueBG2";
            this.cbVueBG2.Size = new System.Drawing.Size(47, 17);
            this.cbVueBG2.TabIndex = 6;
            this.cbVueBG2.Text = "BG2";
            this.cbVueBG2.UseVisualStyleBackColor = true;
            this.cbVueBG2.CheckedChanged += new System.EventHandler(this.cbVueBG2_CheckedChanged);
            // 
            // cbVueBG1
            // 
            this.cbVueBG1.AutoSize = true;
            this.cbVueBG1.Checked = true;
            this.cbVueBG1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueBG1.Location = new System.Drawing.Point(6, 48);
            this.cbVueBG1.Name = "cbVueBG1";
            this.cbVueBG1.Size = new System.Drawing.Size(47, 17);
            this.cbVueBG1.TabIndex = 5;
            this.cbVueBG1.Text = "BG1";
            this.cbVueBG1.UseVisualStyleBackColor = true;
            this.cbVueBG1.CheckedChanged += new System.EventHandler(this.cbVueBG1_CheckedChanged);
            // 
            // cbVueBG0
            // 
            this.cbVueBG0.AutoSize = true;
            this.cbVueBG0.Checked = true;
            this.cbVueBG0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVueBG0.Location = new System.Drawing.Point(6, 25);
            this.cbVueBG0.Name = "cbVueBG0";
            this.cbVueBG0.Size = new System.Drawing.Size(47, 17);
            this.cbVueBG0.TabIndex = 4;
            this.cbVueBG0.Text = "BG0";
            this.cbVueBG0.UseVisualStyleBackColor = true;
            this.cbVueBG0.CheckedChanged += new System.EventHandler(this.cbVueBG0_CheckedChanged);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.cbEditBG4);
            this.gbEdit.Controls.Add(this.cbEditBG3);
            this.gbEdit.Controls.Add(this.cbEditBG2);
            this.gbEdit.Controls.Add(this.cbEditBG1);
            this.gbEdit.Controls.Add(this.cbEditClip);
            this.gbEdit.Location = new System.Drawing.Point(253, 56);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(56, 145);
            this.gbEdit.TabIndex = 8;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit";
            this.gbEdit.Visible = false;
            // 
            // cbEditBG4
            // 
            this.cbEditBG4.AutoSize = true;
            this.cbEditBG4.Location = new System.Drawing.Point(6, 117);
            this.cbEditBG4.Name = "cbEditBG4";
            this.cbEditBG4.Size = new System.Drawing.Size(47, 17);
            this.cbEditBG4.TabIndex = 13;
            this.cbEditBG4.Text = "BG4";
            this.cbEditBG4.UseVisualStyleBackColor = true;
            this.cbEditBG4.CheckedChanged += new System.EventHandler(this.cbEditBG4_CheckedChanged);
            // 
            // cbEditBG3
            // 
            this.cbEditBG3.AutoSize = true;
            this.cbEditBG3.Location = new System.Drawing.Point(6, 94);
            this.cbEditBG3.Name = "cbEditBG3";
            this.cbEditBG3.Size = new System.Drawing.Size(47, 17);
            this.cbEditBG3.TabIndex = 12;
            this.cbEditBG3.Text = "BG3";
            this.cbEditBG3.UseVisualStyleBackColor = true;
            this.cbEditBG3.CheckedChanged += new System.EventHandler(this.cbEditBG3_CheckedChanged);
            // 
            // cbEditBG2
            // 
            this.cbEditBG2.AutoSize = true;
            this.cbEditBG2.Location = new System.Drawing.Point(6, 71);
            this.cbEditBG2.Name = "cbEditBG2";
            this.cbEditBG2.Size = new System.Drawing.Size(47, 17);
            this.cbEditBG2.TabIndex = 11;
            this.cbEditBG2.Text = "BG2";
            this.cbEditBG2.UseVisualStyleBackColor = true;
            this.cbEditBG2.CheckedChanged += new System.EventHandler(this.cbEditBG2_CheckedChanged);
            // 
            // cbEditBG1
            // 
            this.cbEditBG1.AutoSize = true;
            this.cbEditBG1.Location = new System.Drawing.Point(6, 48);
            this.cbEditBG1.Name = "cbEditBG1";
            this.cbEditBG1.Size = new System.Drawing.Size(47, 17);
            this.cbEditBG1.TabIndex = 10;
            this.cbEditBG1.Text = "BG1";
            this.cbEditBG1.UseVisualStyleBackColor = true;
            this.cbEditBG1.CheckedChanged += new System.EventHandler(this.cbEditBG1_CheckedChanged);
            // 
            // cbEditClip
            // 
            this.cbEditClip.AutoSize = true;
            this.cbEditClip.Location = new System.Drawing.Point(6, 25);
            this.cbEditClip.Name = "cbEditClip";
            this.cbEditClip.Size = new System.Drawing.Size(43, 17);
            this.cbEditClip.TabIndex = 9;
            this.cbEditClip.Text = "Clip";
            this.cbEditClip.UseVisualStyleBackColor = true;
            // 
            // gbCollision
            // 
            this.gbCollision.Controls.Add(this.cbCollission);
            this.gbCollision.Location = new System.Drawing.Point(22, 150);
            this.gbCollision.Name = "gbCollision";
            this.gbCollision.Size = new System.Drawing.Size(157, 51);
            this.gbCollision.TabIndex = 9;
            this.gbCollision.TabStop = false;
            this.gbCollision.Text = "Collision";
            this.gbCollision.Visible = false;
            // 
            // cbCollission
            // 
            this.cbCollission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollission.FormattingEnabled = true;
            this.cbCollission.Location = new System.Drawing.Point(9, 19);
            this.cbCollission.Name = "cbCollission";
            this.cbCollission.Size = new System.Drawing.Size(136, 21);
            this.cbCollission.TabIndex = 3;
            // 
            // gbSalle
            // 
            this.gbSalle.Location = new System.Drawing.Point(322, 56);
            this.gbSalle.Name = "gbSalle";
            this.gbSalle.Size = new System.Drawing.Size(1109, 760);
            this.gbSalle.TabIndex = 11;
            this.gbSalle.TabStop = false;
            this.gbSalle.Text = "Salle";
            this.gbSalle.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSOuvrir,
            this.TSEnregistrer,
            this.TSEnregistrerSous,
            this.toolStripSeparator3,
            this.TSTileMode,
            this.TSObjectMode,
            this.toolStripSeparator7,
            this.TSHeader,
            this.toolStripSeparator5,
            this.TSAjouter,
            this.TSSupprimer,
            this.toolStripSeparator6,
            this.TSClipboard,
            this.TSAide});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1443, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSOuvrir
            // 
            this.TSOuvrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("TSOuvrir.Image")));
            this.TSOuvrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSOuvrir.Name = "TSOuvrir";
            this.TSOuvrir.Size = new System.Drawing.Size(24, 24);
            this.TSOuvrir.Text = "Ouvrir";
            this.TSOuvrir.Click += new System.EventHandler(this.TSOuvrir_Click);
            // 
            // TSEnregistrer
            // 
            this.TSEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSEnregistrer.Enabled = false;
            this.TSEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("TSEnregistrer.Image")));
            this.TSEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSEnregistrer.Name = "TSEnregistrer";
            this.TSEnregistrer.Size = new System.Drawing.Size(24, 24);
            this.TSEnregistrer.Text = "Enregistrer";
            this.TSEnregistrer.Click += new System.EventHandler(this.TSEnregistrer_Click);
            // 
            // TSEnregistrerSous
            // 
            this.TSEnregistrerSous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSEnregistrerSous.Enabled = false;
            this.TSEnregistrerSous.Image = ((System.Drawing.Image)(resources.GetObject("TSEnregistrerSous.Image")));
            this.TSEnregistrerSous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSEnregistrerSous.Name = "TSEnregistrerSous";
            this.TSEnregistrerSous.Size = new System.Drawing.Size(24, 24);
            this.TSEnregistrerSous.Text = "Enregistrer sous...";
            this.TSEnregistrerSous.Click += new System.EventHandler(this.TSEnregistrerSous_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // TSTileMode
            // 
            this.TSTileMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSTileMode.Enabled = false;
            this.TSTileMode.Image = ((System.Drawing.Image)(resources.GetObject("TSTileMode.Image")));
            this.TSTileMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSTileMode.Name = "TSTileMode";
            this.TSTileMode.Size = new System.Drawing.Size(24, 24);
            this.TSTileMode.Text = "Mode tile";
            this.TSTileMode.Click += new System.EventHandler(this.TSTileMode_Click);
            // 
            // TSObjectMode
            // 
            this.TSObjectMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSObjectMode.Enabled = false;
            this.TSObjectMode.Image = ((System.Drawing.Image)(resources.GetObject("TSObjectMode.Image")));
            this.TSObjectMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSObjectMode.Name = "TSObjectMode";
            this.TSObjectMode.Size = new System.Drawing.Size(24, 24);
            this.TSObjectMode.Text = "Mode objet";
            this.TSObjectMode.Click += new System.EventHandler(this.TSObjectMode_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // TSHeader
            // 
            this.TSHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSHeader.Enabled = false;
            this.TSHeader.Image = ((System.Drawing.Image)(resources.GetObject("TSHeader.Image")));
            this.TSHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSHeader.Name = "TSHeader";
            this.TSHeader.Size = new System.Drawing.Size(24, 24);
            this.TSHeader.Text = "Header";
            this.TSHeader.Click += new System.EventHandler(this.TSHeader_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // TSAjouter
            // 
            this.TSAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSAjouter.Enabled = false;
            this.TSAjouter.Image = ((System.Drawing.Image)(resources.GetObject("TSAjouter.Image")));
            this.TSAjouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAjouter.Name = "TSAjouter";
            this.TSAjouter.Size = new System.Drawing.Size(24, 24);
            this.TSAjouter.Text = "Ajouter";
            this.TSAjouter.Click += new System.EventHandler(this.TSAjouter_Click);
            // 
            // TSSupprimer
            // 
            this.TSSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSSupprimer.Enabled = false;
            this.TSSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("TSSupprimer.Image")));
            this.TSSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSupprimer.Name = "TSSupprimer";
            this.TSSupprimer.Size = new System.Drawing.Size(24, 24);
            this.TSSupprimer.Text = "Supprimer";
            this.TSSupprimer.Click += new System.EventHandler(this.TSSupprimer_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // TSAide
            // 
            this.TSAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSAide.Image = ((System.Drawing.Image)(resources.GetObject("TSAide.Image")));
            this.TSAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAide.Name = "TSAide";
            this.TSAide.Size = new System.Drawing.Size(24, 24);
            this.TSAide.Text = "Aide";
            this.TSAide.Click += new System.EventHandler(this.TSAide_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSClip,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 832);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1443, 25);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TSClip
            // 
            this.TSClip.Name = "TSClip";
            this.TSClip.Size = new System.Drawing.Size(39, 22);
            this.TSClip.Text = "0 - Air";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // TSClipboard
            // 
            this.TSClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSClipboard.Image = ((System.Drawing.Image)(resources.GetObject("TSClipboard.Image")));
            this.TSClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSClipboard.Name = "TSClipboard";
            this.TSClipboard.Size = new System.Drawing.Size(24, 24);
            this.TSClipboard.Text = "Clipboard";
            this.TSClipboard.Click += new System.EventHandler(this.TSClipboard_Click);
            // 
            // MSVue
            // 
            this.MSVue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSVueBG0,
            this.MSVueBG1,
            this.MSVueBG2,
            this.MSVueBG3,
            this.MSVueBG4,
            this.toolStripSeparator8,
            this.MSVueClipboard});
            this.MSVue.Enabled = false;
            this.MSVue.Name = "MSVue";
            this.MSVue.Size = new System.Drawing.Size(39, 20);
            this.MSVue.Text = "Vue";
            // 
            // MSVueBG0
            // 
            this.MSVueBG0.Name = "MSVueBG0";
            this.MSVueBG0.Size = new System.Drawing.Size(180, 22);
            this.MSVueBG0.Text = "BG0";
            this.MSVueBG0.Click += new System.EventHandler(this.MSVueBG0_Click);
            // 
            // MSVueBG1
            // 
            this.MSVueBG1.Name = "MSVueBG1";
            this.MSVueBG1.Size = new System.Drawing.Size(180, 22);
            this.MSVueBG1.Text = "BG1";
            this.MSVueBG1.Click += new System.EventHandler(this.MSVueBG1_Click);
            // 
            // MSVueBG2
            // 
            this.MSVueBG2.Name = "MSVueBG2";
            this.MSVueBG2.Size = new System.Drawing.Size(180, 22);
            this.MSVueBG2.Text = "BG2";
            this.MSVueBG2.Click += new System.EventHandler(this.MSVueBG2_Click);
            // 
            // MSVueBG3
            // 
            this.MSVueBG3.Name = "MSVueBG3";
            this.MSVueBG3.Size = new System.Drawing.Size(180, 22);
            this.MSVueBG3.Text = "BG3";
            this.MSVueBG3.Click += new System.EventHandler(this.MSVueBG3_Click);
            // 
            // MSVueBG4
            // 
            this.MSVueBG4.Name = "MSVueBG4";
            this.MSVueBG4.Size = new System.Drawing.Size(180, 22);
            this.MSVueBG4.Text = "BG4";
            this.MSVueBG4.Click += new System.EventHandler(this.MSVueBG4_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // MSVueClipboard
            // 
            this.MSVueClipboard.Name = "MSVueClipboard";
            this.MSVueClipboard.Size = new System.Drawing.Size(180, 22);
            this.MSVueClipboard.Text = "Clipboard";
            this.MSVueClipboard.Click += new System.EventHandler(this.MSVueClipboard_Click);
            // 
            // SudoEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbSalle);
            this.Controls.Add(this.gbCollision);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbVue);
            this.Controls.Add(this.gbEmplacement);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "SudoEditor";
            this.Text = "SudoEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SudoEditor_FormClosing);
            this.Load += new System.EventHandler(this.SudoEditor_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SudoEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SudoEditor_DragEnter);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.gbEmplacement.ResumeLayout(false);
            this.gbEmplacement.PerformLayout();
            this.gbVue.ResumeLayout(false);
            this.gbVue.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbCollision.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MSProjet;
        private System.Windows.Forms.ToolStripMenuItem MSProjetNouveau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MSProjetOuvrir;
        private System.Windows.Forms.ToolStripMenuItem MSProjetEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem MSProjetEnregistrerSous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MSProjetFermer;
        private System.Windows.Forms.GroupBox gbEmplacement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVue;
        private System.Windows.Forms.CheckBox cbVueBG0;
        private System.Windows.Forms.CheckBox cbVueBG4;
        private System.Windows.Forms.CheckBox cbVueBG3;
        private System.Windows.Forms.CheckBox cbVueBG2;
        private System.Windows.Forms.CheckBox cbVueBG1;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.CheckBox cbEditBG4;
        private System.Windows.Forms.CheckBox cbEditBG3;
        private System.Windows.Forms.CheckBox cbEditBG2;
        private System.Windows.Forms.CheckBox cbEditBG1;
        private System.Windows.Forms.CheckBox cbEditClip;
        private System.Windows.Forms.GroupBox gbCollision;
        private System.Windows.Forms.ComboBox cbCollission;
        private System.Windows.Forms.GroupBox gbSalle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSOuvrir;
        private System.Windows.Forms.ToolStripButton TSEnregistrer;
        private System.Windows.Forms.ToolStripButton TSEnregistrerSous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSTileMode;
        private System.Windows.Forms.ToolStripButton TSObjectMode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel TSClip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSAjouter;
        private System.Windows.Forms.ToolStripButton TSSupprimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TSAide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton TSHeader;
        private System.Windows.Forms.ToolStripMenuItem MSOptions;
        private System.Windows.Forms.ToolStripMenuItem MSOptionsDiscord;
        private System.Windows.Forms.ToolStripButton TSClipboard;
        private System.Windows.Forms.ToolStripMenuItem MSVue;
        private System.Windows.Forms.ToolStripMenuItem MSVueBG0;
        private System.Windows.Forms.ToolStripMenuItem MSVueBG1;
        private System.Windows.Forms.ToolStripMenuItem MSVueBG2;
        private System.Windows.Forms.ToolStripMenuItem MSVueBG3;
        private System.Windows.Forms.ToolStripMenuItem MSVueBG4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem MSVueClipboard;
    }
}

