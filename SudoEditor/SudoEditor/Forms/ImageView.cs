using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudoEditor
{
    public partial class ImageView : Form
    {
        public ImageView()
        {
            InitializeComponent();
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
            Size = new Size(Suppression.image.Width + 60, Suppression.image.Height + 95);
            Text = Suppression.image.Tag.ToString();
            MaximumSize = Size;
            MinimumSize = Size;
            gbImage.Size = new Size(Suppression.image.Width + 26, Suppression.image.Height + 32);
            pbImage.BackColor = Color.FromArgb(40, 50, 50);
            pbImage.Size = Suppression.image.Size;
            pbImage.Image = Suppression.image;
        }
    }
}
