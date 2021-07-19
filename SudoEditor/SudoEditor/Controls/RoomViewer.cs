using System.Drawing;
using System.Windows.Forms;

namespace SudoEditor
{
    public class RoomViewer : Control
    {
        public override Image BackgroundImage
        {
            get => base.BackgroundImage;
            set
            {
                base.BackgroundImage = value;
                Size = base.BackgroundImage.Size;
            }
        }
        public Rectangle CursorRectangle { get; set; }
        public readonly Pen RedPen = new Pen(Color.Red, 1);

        public RoomViewer()
        {
            SuspendLayout();
            ResumeLayout(false);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.FromArgb(50, 50, 50);
        }
    }
}
