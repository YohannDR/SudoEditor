
namespace SudoEditor
{
    partial class ImageView
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(15, 21);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(256, 313);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.Location = new System.Drawing.Point(12, 12);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(289, 345);
            this.gbImage.TabIndex = 1;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 365);
            this.Controls.Add(this.gbImage);
            this.Name = "ImageView";
            this.Text = "ImageView";
            this.Load += new System.EventHandler(this.ImageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox gbImage;
    }
}