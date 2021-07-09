using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudoEditor
{
    public partial class ImageView : Form
    {
        public static Image Image;

        public ImageView()
        {
            InitializeComponent();
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
            Size = new Size(Image.Width + 60, Image.Height + 95);
            Text = Image.Tag.ToString();
            MaximumSize = Size;
            MinimumSize = Size;
            gbImage.Size = new Size(Image.Width + 26, Image.Height + 32);
            pbImage.BackColor = Color.FromArgb(40, 50, 50);
            pbImage.Size = Image.Size;
            pbImage.Image = Image;
        }
    }
}
