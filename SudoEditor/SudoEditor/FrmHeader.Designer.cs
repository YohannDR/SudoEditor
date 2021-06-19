
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
            this.gbBG.SuspendLayout();
            this.gbMap.SuspendLayout();
            this.gbMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBG
            // 
            this.gbBG.Controls.Add(this.btnAfficherB);
            this.gbBG.Controls.Add(this.tbBG0);
            this.gbBG.Controls.Add(this.label6);
            this.gbBG.Controls.Add(this.tbTileset);
            this.gbBG.Controls.Add(this.btnAfficherT);
            this.gbBG.Controls.Add(this.tbTransparency);
            this.gbBG.Controls.Add(this.label2);
            this.gbBG.Controls.Add(this.label1);
            this.gbBG.Location = new System.Drawing.Point(16, 15);
            this.gbBG.Margin = new System.Windows.Forms.Padding(4);
            this.gbBG.Name = "gbBG";
            this.gbBG.Padding = new System.Windows.Forms.Padding(4);
            this.gbBG.Size = new System.Drawing.Size(171, 231);
            this.gbBG.TabIndex = 0;
            this.gbBG.TabStop = false;
            this.gbBG.Text = "Background";
            // 
            // btnAfficherB
            // 
            this.btnAfficherB.Location = new System.Drawing.Point(39, 155);
            this.btnAfficherB.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherB.Name = "btnAfficherB";
            this.btnAfficherB.Size = new System.Drawing.Size(100, 28);
            this.btnAfficherB.TabIndex = 4;
            this.btnAfficherB.Text = "Afficher";
            this.btnAfficherB.UseVisualStyleBackColor = true;
            this.btnAfficherB.Click += new System.EventHandler(this.btnAfficherB_Click);
            // 
            // tbBG0
            // 
            this.tbBG0.Location = new System.Drawing.Point(89, 114);
            this.tbBG0.Name = "tbBG0";
            this.tbBG0.Size = new System.Drawing.Size(67, 22);
            this.tbBG0.TabIndex = 3;
            this.tbBG0.TextChanged += new System.EventHandler(this.tbBG0_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "BG0 :";
            // 
            // tbTileset
            // 
            this.tbTileset.Location = new System.Drawing.Point(89, 27);
            this.tbTileset.Name = "tbTileset";
            this.tbTileset.Size = new System.Drawing.Size(67, 22);
            this.tbTileset.TabIndex = 1;
            this.tbTileset.TextChanged += new System.EventHandler(this.tbTileset_TextChanged);
            // 
            // btnAfficherT
            // 
            this.btnAfficherT.Location = new System.Drawing.Point(39, 67);
            this.btnAfficherT.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherT.Name = "btnAfficherT";
            this.btnAfficherT.Size = new System.Drawing.Size(100, 28);
            this.btnAfficherT.TabIndex = 2;
            this.btnAfficherT.Text = "Afficher";
            this.btnAfficherT.UseVisualStyleBackColor = true;
            this.btnAfficherT.Click += new System.EventHandler(this.btnAfficherT_Click);
            // 
            // tbTransparency
            // 
            this.tbTransparency.Location = new System.Drawing.Point(121, 197);
            this.tbTransparency.Margin = new System.Windows.Forms.Padding(4);
            this.tbTransparency.MaxLength = 3;
            this.tbTransparency.Name = "tbTransparency";
            this.tbTransparency.Size = new System.Drawing.Size(35, 22);
            this.tbTransparency.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transparence :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tileset :";
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.tbMapY);
            this.gbMap.Controls.Add(this.tbMapX);
            this.gbMap.Controls.Add(this.label4);
            this.gbMap.Controls.Add(this.label3);
            this.gbMap.Location = new System.Drawing.Point(207, 18);
            this.gbMap.Margin = new System.Windows.Forms.Padding(4);
            this.gbMap.Name = "gbMap";
            this.gbMap.Padding = new System.Windows.Forms.Padding(4);
            this.gbMap.Size = new System.Drawing.Size(128, 100);
            this.gbMap.TabIndex = 1;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Map";
            // 
            // tbMapY
            // 
            this.tbMapY.Location = new System.Drawing.Point(84, 62);
            this.tbMapY.Margin = new System.Windows.Forms.Padding(4);
            this.tbMapY.MaxLength = 3;
            this.tbMapY.Name = "tbMapY";
            this.tbMapY.Size = new System.Drawing.Size(35, 22);
            this.tbMapY.TabIndex = 7;
            // 
            // tbMapX
            // 
            this.tbMapX.Location = new System.Drawing.Point(84, 24);
            this.tbMapX.Margin = new System.Windows.Forms.Padding(4);
            this.tbMapX.MaxLength = 3;
            this.tbMapX.Name = "tbMapX";
            this.tbMapX.Size = new System.Drawing.Size(35, 22);
            this.tbMapX.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Map Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Map X :";
            // 
            // gbMusic
            // 
            this.gbMusic.Controls.Add(this.tbMusic);
            this.gbMusic.Controls.Add(this.label5);
            this.gbMusic.Location = new System.Drawing.Point(207, 126);
            this.gbMusic.Margin = new System.Windows.Forms.Padding(4);
            this.gbMusic.Name = "gbMusic";
            this.gbMusic.Padding = new System.Windows.Forms.Padding(4);
            this.gbMusic.Size = new System.Drawing.Size(128, 64);
            this.gbMusic.TabIndex = 2;
            this.gbMusic.TabStop = false;
            this.gbMusic.Text = "Musique";
            // 
            // tbMusic
            // 
            this.tbMusic.Location = new System.Drawing.Point(84, 28);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(35, 22);
            this.tbMusic.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Musique :";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(219, 212);
            this.btnAppliquer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(89, 34);
            this.btnAppliquer.TabIndex = 9;
            this.btnAppliquer.Text = "&Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // FrmHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.gbMusic);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.gbBG);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}