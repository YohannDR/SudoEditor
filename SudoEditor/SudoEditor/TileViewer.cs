using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudoEditor
{
    public class TileViewer : Control
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
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        public ScrollableControl Scroll = new ScrollableControl();

        public Rectangle CursorRectangle { get; set; }
        public readonly Pen RedPen = new Pen(Color.Red, 1);

        public Rectangle SelectionRectangle { get; set; }
        public readonly Pen WhitePen = new Pen(Color.White, 1);

        Point RedRectanglePosition = new Point(0, 0);
        Point SelectionStart = new Point(0, 0);
        Size SelectionSize = new Size(0, 0);

        bool selecting = false;
        bool xReversed = false;
        bool yReversed = false;

        public TileViewer()
        {
            SuspendLayout();
            ResumeLayout(false);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.FromArgb(40, 50, 50);
            Scroll.AutoScroll = true;

            MouseDown += TileSet_MouseDown;
            MouseUp += TileSet_MouseUp;
            MouseMove += TileSet_MouseMove;
            MouseEnter += TileSet_MouseEnter;
            MouseLeave += TileSet_MouseLeave;
            Paint += TileSet_Paint;
        }

        private void TileSet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
            if (!selecting) SelectionStart = new Point((e.X >> 4) * 16, (e.Y >> 4) * 16);
            selecting = true;
            SelectionSize = new Size(16, 16);
        }
        private void TileSet_MouseUp(object sender, MouseEventArgs e)
        {
            selecting = false;
        }
        private void TileSet_MouseMove(object sender, MouseEventArgs e) 
        { 
            RedRectanglePosition = new Point(e.X, e.Y);
            if (selecting && SudoEditor.isMouseInTileset && RedRectanglePosition.X <= Size.Width - 1 && RedRectanglePosition.Y <= Size.Height - 1)
            {
                SelectionSize.Width++;
                SelectionSize.Height++;

                SelectionSize.Width = (e.X - SelectionStart.X + 16 >> 4) * 16;
                SelectionSize.Height = (e.Y - SelectionStart.Y + 16 >> 4) * 16;
                SudoEditor.TSSize.Text = $"{Math.Abs(SelectionSize.Width / 16)} x {Math.Abs(SelectionSize.Height / 16)}";
                if (RedRectanglePosition.X <= SelectionStart.X && SelectionSize != new Size(16, 16)) xReversed = true; else xReversed = false;
                if (RedRectanglePosition.Y <= SelectionStart.Y && SelectionSize != new Size(16, 16)) yReversed = true; else yReversed = false;
            }
            TileSet_Paint(0, new PaintEventArgs(CreateGraphics(), new Rectangle()));
        }

        private void TileSet_MouseEnter(object sender, EventArgs e) => SudoEditor.isMouseInTileset = true;
        private void TileSet_MouseLeave(object sender, EventArgs e) => SudoEditor.isMouseInTileset = false;

        private void TileSet_Paint(object sender, PaintEventArgs e)
        {
            if (SudoEditor.isMouseInTileset)
            {
                CursorRectangle = new Rectangle(new Point((RedRectanglePosition.X >> 4) * 16, (RedRectanglePosition.Y >> 4) * 16), new Size(15, 15));
                e.Graphics.DrawRectangle(RedPen, CursorRectangle);
                Invalidate(new Rectangle(CursorRectangle.Location, new Size(16, 16)));
            if (!xReversed && !yReversed) 
                SelectionRectangle = new Rectangle(new Point(SelectionStart.X, SelectionStart.Y), new Size(SelectionSize.Width - 1, SelectionSize.Height - 1));
            else if (xReversed && !yReversed && selecting)
                SelectionRectangle = new Rectangle(new Point(SelectionStart.X - ((SelectionStart.X - RedRectanglePosition.X >> 4) * 16) - 16, SelectionStart.Y), new Size(Math.Abs(SelectionSize.Width) + 31, SelectionSize.Height - 1));
            else if (!xReversed && yReversed && selecting)
                SelectionRectangle = new Rectangle(new Point(SelectionStart.X, SelectionStart.Y - ((SelectionStart.Y - RedRectanglePosition.Y >> 4) * 16) - 16), new Size(SelectionSize.Width - 1, Math.Abs(SelectionSize.Height) + 31));
            else if (xReversed && yReversed && selecting)
                SelectionRectangle = new Rectangle(new Point(SelectionStart.X - ((SelectionStart.X - RedRectanglePosition.X >> 4) * 16) - 16, SelectionStart.Y - ((SelectionStart.Y - RedRectanglePosition.Y >> 4) * 16) - 16), new Size(Math.Abs(SelectionSize.Width) + 31, Math.Abs(SelectionSize.Height) + 31));
            }

            e.Graphics.DrawRectangle(WhitePen, SelectionRectangle);
            Invalidate(new Rectangle(SelectionRectangle.Location, new Size(SelectionRectangle.Width + 1, SelectionRectangle.Height + 1)));
        }
    }
}
