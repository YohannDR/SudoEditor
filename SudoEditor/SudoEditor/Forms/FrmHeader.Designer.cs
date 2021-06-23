
namespace SudoEditor
{
    partial class FrmHeader
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
            this.gbBG = new System.Windows.Forms.GroupBox();
            this.lblFoundB = new System.Windows.Forms.Label();
            this.lblFoundT = new System.Windows.Forms.Label();
            this.btnAfficherB = new System.Windows.Forms.Button();
            this.tbBG0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTileset = new System.Windows.Forms.TextBox();
            this.btnAfficherT = new System.Windows.Forms.Button();
            this.tbTransparency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.tbMapY = new System.Windows.Forms.TextBox();
            this.tbMapX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMusic = new System.Windows.Forms.GroupBox();
            this.tbMusic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbBG.SuspendLayout();
            this.gbMap.SuspendLayout();
            this.gbMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBG
            // 
            this.gbBG.Controls.Add(this.lblFoundB);
            this.gbBG.Controls.Add(this.lblFoundT);
            this.gbBG.Controls.Add(this.btnAfficherB);
            this.gbBG.Controls.Add(this.tbBG0);
            this.gbBG.Controls.Add(this.label6);
            this.gbBG.Controls.Add(this.tbTileset);
            this.gbBG.Controls.Add(this.btnAfficherT);
            this.gbBG.Controls.Add(this.tbTransparency);
            this.gbBG.Controls.Add(this.label2);
            this.gbBG.Controls.Add(this.label1);
            this.gbBG.Location = new System.Drawing.Point(12, 15);
            this.gbBG.Name = "gbBG";
            this.gbBG.Size = new System.Drawing.Size(137, 185);
            this.gbBG.TabIndex = 0;
            this.gbBG.TabStop = false;
            this.gbBG.Text = "Background";
            // 
            // lblFoundB
            // 
            this.lblFoundB.AutoSize = true;
            this.lblFoundB.Location = new System.Drawing.Point(121, 97);
            this.lblFoundB.Name = "lblFoundB";
            this.lblFoundB.Size = new System.Drawing.Size(15, 13);
            this.lblFoundB.TabIndex = 11;
            this.lblFoundB.Text = "✓";
            // 
            // lblFoundT
            // 
            this.lblFoundT.AutoSize = true;
            this.lblFoundT.Location = new System.Drawing.Point(121, 25);
            this.lblFoundT.Name = "lblFoundT";
            this.lblFoundT.Size = new System.Drawing.Size(15, 13);
            this.lblFoundT.TabIndex = 10;
            this.lblFoundT.Text = "✓";
            // 
            // btnAfficherB
            // 
            this.btnAfficherB.Location = new System.Drawing.Point(29, 126);
            this.btnAfficherB.Name = "btnAfficherB";
            this.btnAfficherB.Size = new System.Drawing.Size(75, 23);
            this.btnAfficherB.TabIndex = 4;
            this.btnAfficherB.Text = "Afficher";
            this.btnAfficherB.UseVisualStyleBackColor = true;
            this.btnAfficherB.Click += new System.EventHandler(this.btnAfficherB_Click);
            // 
            // tbBG0
            // 
            this.tbBG0.Location = new System.Drawing.Point(67, 93);
            this.tbBG0.Margin = new System.Windows.Forms.Padding(2);
            this.tbBG0.Name = "tbBG0";
            this.tbBG0.Size = new System.Drawing.Size(51, 20);
            this.tbBG0.TabIndex = 3;
            this.tbBG0.TextChanged += new System.EventHandler(this.tbBG0_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "BG0 :";
            // 
            // tbTileset
            // 
            this.tbTileset.Location = new System.Drawing.Point(67, 22);
            this.tbTileset.Margin = new System.Windows.Forms.Padding(2);
            this.tbTileset.Name = "tbTileset";
            this.tbTileset.Size = new System.Drawing.Size(51, 20);
            this.tbTileset.TabIndex = 1;
            this.tbTileset.TextChanged += new System.EventHandler(this.tbTileset_TextChanged);
            // 
            // btnAfficherT
            // 
            this.btnAfficherT.Location = new System.Drawing.Point(29, 54);
            this.btnAfficherT.Name = "btnAfficherT";
            this.btnAfficherT.Size = new System.Drawing.Size(75, 23);
            this.btnAfficherT.TabIndex = 2;
            this.btnAfficherT.Text = "Afficher";
            this.btnAfficherT.UseVisualStyleBackColor = true;
            this.btnAfficherT.Click += new System.EventHandler(this.btnAfficherT_Click);
            // 
            // tbTransparency
            // 
            this.tbTransparency.Location = new System.Drawing.Point(91, 160);
            this.tbTransparency.MaxLength = 3;
            this.tbTransparency.Name = "tbTransparency";
            this.tbTransparency.Size = new System.Drawing.Size(27, 20);
            this.tbTransparency.TabIndex = 5;
            this.tbTransparency.TextChanged += new System.EventHandler(this.tbTransparency_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transparence :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tileset :";
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.label8);
            this.gbMap.Controls.Add(this.label7);
            this.gbMap.Controls.Add(this.tbMapY);
            this.gbMap.Controls.Add(this.tbMapX);
            this.gbMap.Controls.Add(this.label4);
            this.gbMap.Controls.Add(this.label3);
            this.gbMap.Location = new System.Drawing.Point(155, 15);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(96, 81);
            this.gbMap.TabIndex = 1;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Minimap";
            // 
            // tbMapY
            // 
            this.tbMapY.Location = new System.Drawing.Point(47, 50);
            this.tbMapY.MaxLength = 3;
            this.tbMapY.Name = "tbMapY";
            this.tbMapY.Size = new System.Drawing.Size(27, 20);
            this.tbMapY.TabIndex = 7;
            this.tbMapY.TextChanged += new System.EventHandler(this.tbMapY_TextChanged);
            // 
            // tbMapX
            // 
            this.tbMapX.Location = new System.Drawing.Point(46, 20);
            this.tbMapX.MaxLength = 3;
            this.tbMapX.Name = "tbMapX";
            this.tbMapX.Size = new System.Drawing.Size(27, 20);
            this.tbMapX.TabIndex = 6;
            this.tbMapX.TextChanged += new System.EventHandler(this.tbMapX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "X :";
            // 
            // gbMusic
            // 
            this.gbMusic.Controls.Add(this.label9);
            this.gbMusic.Controls.Add(this.tbMusic);
            this.gbMusic.Controls.Add(this.label5);
            this.gbMusic.Location = new System.Drawing.Point(155, 102);
            this.gbMusic.Name = "gbMusic";
            this.gbMusic.Size = new System.Drawing.Size(96, 52);
            this.gbMusic.TabIndex = 2;
            this.gbMusic.TabStop = false;
            this.gbMusic.Text = "Musique";
            // 
            // tbMusic
            // 
            this.tbMusic.Location = new System.Drawing.Point(47, 23);
            this.tbMusic.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(27, 20);
            this.tbMusic.TabIndex = 8;
            this.tbMusic.TextChanged += new System.EventHandler(this.tbMusic_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID :";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(164, 172);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(67, 28);
            this.btnAppliquer.TabIndex = 9;
            this.btnAppliquer.Text = "&Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "✓";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "✓";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "✓";
            // 
            // FrmHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 212);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.gbMusic);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.gbBG);
            this.Name = "FrmHeader";
            this.Text = "Header";
            this.Load += new System.EventHandler(this.FrmHeader_Load);
            this.gbBG.ResumeLayout(false);
            this.gbBG.PerformLayout();
            this.gbMap.ResumeLayout(false);
            this.gbMap.PerformLayout();
            this.gbMusic.ResumeLayout(false);
            this.gbMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTransparency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMap;
        private System.Windows.Forms.TextBox tbMapY;
        private System.Windows.Forms.TextBox tbMapX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMusic;
        private System.Windows.Forms.Button btnAfficherT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.TextBox tbTileset;
        private System.Windows.Forms.TextBox tbMusic;
        private System.Windows.Forms.TextBox tbBG0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAfficherB;
        private System.Windows.Forms.Label lblFoundT;
        private System.Windows.Forms.Label lblFoundB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}