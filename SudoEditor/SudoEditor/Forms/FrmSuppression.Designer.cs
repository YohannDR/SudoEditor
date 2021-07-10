
namespace SudoEditor
{
    partial class FrmSuppression
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TAB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvZonesZ = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btnSupprZ = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSalleS = new System.Windows.Forms.ComboBox();
            this.btnSupprS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbZoneS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSupprimerT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumT = new System.Windows.Forms.ComboBox();
            this.pbPreviewT = new System.Windows.Forms.PictureBox();
            this.gbPreviewT = new System.Windows.Forms.GroupBox();
            this.btnImageFullT = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnImageFullB = new System.Windows.Forms.Button();
            this.gbPreviewB = new System.Windows.Forms.GroupBox();
            this.pbPreviewB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumB = new System.Windows.Forms.ComboBox();
            this.btnSupprB = new System.Windows.Forms.Button();
            this.TAB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewT)).BeginInit();
            this.gbPreviewT.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbPreviewB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewB)).BeginInit();
            this.SuspendLayout();
            // 
            // TAB
            // 
            this.TAB.Controls.Add(this.tabPage1);
            this.TAB.Controls.Add(this.tabPage2);
            this.TAB.Controls.Add(this.tabPage3);
            this.TAB.Controls.Add(this.tabPage4);
            this.TAB.Location = new System.Drawing.Point(12, 12);
            this.TAB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TAB.Name = "TAB";
            this.TAB.SelectedIndex = 0;
            this.TAB.Size = new System.Drawing.Size(447, 238);
            this.TAB.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvZonesZ);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSupprZ);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(439, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zone";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvZonesZ
            // 
            this.lvZonesZ.BackColor = System.Drawing.Color.White;
            this.lvZonesZ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader4});
            this.lvZonesZ.HideSelection = false;
            this.lvZonesZ.Location = new System.Drawing.Point(32, 42);
            this.lvZonesZ.Margin = new System.Windows.Forms.Padding(4);
            this.lvZonesZ.Name = "lvZonesZ";
            this.lvZonesZ.Size = new System.Drawing.Size(259, 150);
            this.lvZonesZ.TabIndex = 6;
            this.lvZonesZ.UseCompatibleStateImageBehavior = false;
            this.lvZonesZ.View = System.Windows.Forms.View.Details;
            this.lvZonesZ.SelectedIndexChanged += new System.EventHandler(this.lvZonesZ_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Nom";
            this.columnHeader0.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salles";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Zones :";
            // 
            // btnSupprZ
            // 
            this.btnSupprZ.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprZ.Enabled = false;
            this.btnSupprZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprZ.Location = new System.Drawing.Point(329, 170);
            this.btnSupprZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprZ.Name = "btnSupprZ";
            this.btnSupprZ.Size = new System.Drawing.Size(99, 31);
            this.btnSupprZ.TabIndex = 3;
            this.btnSupprZ.Text = "Supprimer";
            this.btnSupprZ.UseVisualStyleBackColor = false;
            this.btnSupprZ.Click += new System.EventHandler(this.btnSupprZ_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbSalleS);
            this.tabPage2.Controls.Add(this.btnSupprS);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbZoneS);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(439, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbSalleS
            // 
            this.cbSalleS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleS.FormattingEnabled = true;
            this.cbSalleS.Location = new System.Drawing.Point(81, 70);
            this.cbSalleS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalleS.Name = "cbSalleS";
            this.cbSalleS.Size = new System.Drawing.Size(113, 24);
            this.cbSalleS.TabIndex = 7;
            // 
            // btnSupprS
            // 
            this.btnSupprS.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprS.Location = new System.Drawing.Point(329, 170);
            this.btnSupprS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprS.Name = "btnSupprS";
            this.btnSupprS.Size = new System.Drawing.Size(99, 31);
            this.btnSupprS.TabIndex = 7;
            this.btnSupprS.Text = "Supprimer";
            this.btnSupprS.UseVisualStyleBackColor = false;
            this.btnSupprS.Click += new System.EventHandler(this.btnSupprS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salle :";
            // 
            // cbZoneS
            // 
            this.cbZoneS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneS.FormattingEnabled = true;
            this.cbZoneS.Location = new System.Drawing.Point(81, 26);
            this.cbZoneS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbZoneS.Name = "cbZoneS";
            this.cbZoneS.Size = new System.Drawing.Size(113, 24);
            this.cbZoneS.TabIndex = 5;
            this.cbZoneS.SelectedIndexChanged += new System.EventHandler(this.cbZoneS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zone :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnImageFullT);
            this.tabPage3.Controls.Add(this.gbPreviewT);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cbNumT);
            this.tabPage3.Controls.Add(this.btnSupprimerT);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(439, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tileset";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerT
            // 
            this.btnSupprimerT.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimerT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimerT.Location = new System.Drawing.Point(329, 170);
            this.btnSupprimerT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerT.Name = "btnSupprimerT";
            this.btnSupprimerT.Size = new System.Drawing.Size(99, 31);
            this.btnSupprimerT.TabIndex = 5;
            this.btnSupprimerT.Text = "Supprimer";
            this.btnSupprimerT.UseVisualStyleBackColor = false;
            this.btnSupprimerT.Click += new System.EventHandler(this.btnSupprimerT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numéro :";
            // 
            // cbNumT
            // 
            this.cbNumT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumT.FormattingEnabled = true;
            this.cbNumT.Location = new System.Drawing.Point(343, 26);
            this.cbNumT.Name = "cbNumT";
            this.cbNumT.Size = new System.Drawing.Size(71, 24);
            this.cbNumT.TabIndex = 6;
            this.cbNumT.SelectedIndexChanged += new System.EventHandler(this.cbNumT_SelectedIndexChanged);
            // 
            // pbPreviewT
            // 
            this.pbPreviewT.Location = new System.Drawing.Point(6, 21);
            this.pbPreviewT.Name = "pbPreviewT";
            this.pbPreviewT.Size = new System.Drawing.Size(91, 171);
            this.pbPreviewT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreviewT.TabIndex = 9;
            this.pbPreviewT.TabStop = false;
            // 
            // gbPreviewT
            // 
            this.gbPreviewT.Controls.Add(this.pbPreviewT);
            this.gbPreviewT.Location = new System.Drawing.Point(19, 3);
            this.gbPreviewT.Name = "gbPreviewT";
            this.gbPreviewT.Size = new System.Drawing.Size(104, 198);
            this.gbPreviewT.TabIndex = 8;
            this.gbPreviewT.TabStop = false;
            this.gbPreviewT.Text = "Preview";
            // 
            // btnImageFullT
            // 
            this.btnImageFullT.Enabled = false;
            this.btnImageFullT.Location = new System.Drawing.Point(129, 170);
            this.btnImageFullT.Name = "btnImageFullT";
            this.btnImageFullT.Size = new System.Drawing.Size(109, 29);
            this.btnImageFullT.TabIndex = 9;
            this.btnImageFullT.Text = "Image entière";
            this.btnImageFullT.UseVisualStyleBackColor = true;
            this.btnImageFullT.Click += new System.EventHandler(this.btnImageFull_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnImageFullB);
            this.tabPage4.Controls.Add(this.gbPreviewB);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.cbNumB);
            this.tabPage4.Controls.Add(this.btnSupprB);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(439, 209);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Background";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnImageFullB
            // 
            this.btnImageFullB.Enabled = false;
            this.btnImageFullB.Location = new System.Drawing.Point(270, 98);
            this.btnImageFullB.Name = "btnImageFullB";
            this.btnImageFullB.Size = new System.Drawing.Size(109, 29);
            this.btnImageFullB.TabIndex = 14;
            this.btnImageFullB.Text = "Image entière";
            this.btnImageFullB.UseVisualStyleBackColor = true;
            this.btnImageFullB.Click += new System.EventHandler(this.btnImageFullB_Click);
            // 
            // gbPreviewB
            // 
            this.gbPreviewB.Controls.Add(this.pbPreviewB);
            this.gbPreviewB.Location = new System.Drawing.Point(15, 5);
            this.gbPreviewB.Name = "gbPreviewB";
            this.gbPreviewB.Size = new System.Drawing.Size(246, 198);
            this.gbPreviewB.TabIndex = 13;
            this.gbPreviewB.TabStop = false;
            this.gbPreviewB.Text = "Preview";
            // 
            // pbPreviewB
            // 
            this.pbPreviewB.Location = new System.Drawing.Point(6, 21);
            this.pbPreviewB.Name = "pbPreviewB";
            this.pbPreviewB.Size = new System.Drawing.Size(234, 171);
            this.pbPreviewB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreviewB.TabIndex = 9;
            this.pbPreviewB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numéro :";
            // 
            // cbNumB
            // 
            this.cbNumB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumB.FormattingEnabled = true;
            this.cbNumB.Location = new System.Drawing.Point(339, 28);
            this.cbNumB.Name = "cbNumB";
            this.cbNumB.Size = new System.Drawing.Size(71, 24);
            this.cbNumB.TabIndex = 11;
            this.cbNumB.SelectedIndexChanged += new System.EventHandler(this.cbNumB_SelectedIndexChanged);
            // 
            // btnSupprB
            // 
            this.btnSupprB.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprB.Location = new System.Drawing.Point(325, 172);
            this.btnSupprB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprB.Name = "btnSupprB";
            this.btnSupprB.Size = new System.Drawing.Size(99, 31);
            this.btnSupprB.TabIndex = 10;
            this.btnSupprB.Text = "Supprimer";
            this.btnSupprB.UseVisualStyleBackColor = false;
            // 
            // Suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 257);
            this.Controls.Add(this.TAB);
            this.MinimumSize = new System.Drawing.Size(479, 304);
            this.Name = "Suppression";
            this.Text = "Suppression";
            this.Load += new System.EventHandler(this.Suppression_Load);
            this.TAB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewT)).EndInit();
            this.gbPreviewT.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbPreviewB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TAB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSupprZ;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSupprS;
        private System.Windows.Forms.ComboBox cbSalleS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbZoneS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSupprimerT;
        private System.Windows.Forms.ListView lvZonesZ;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumT;
        private System.Windows.Forms.GroupBox gbPreviewT;
        private System.Windows.Forms.PictureBox pbPreviewT;
        private System.Windows.Forms.Button btnImageFullT;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnImageFullB;
        private System.Windows.Forms.GroupBox gbPreviewB;
        private System.Windows.Forms.PictureBox pbPreviewB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumB;
        private System.Windows.Forms.Button btnSupprB;
    }
}