using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudoEditor
{
    public struct Header
    {
        public int TilesetNbr { get; set; }
        public int BG0Nbr { get; set; }
        public double Transparency { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public int MusicNbr { get; set; }
        public double HorizontalScroll { get; set; }
        public double VerticalScroll { get; set; }

        public Header(int tilesetNbr, int bg0Nbr, double transparency, int mapX, int mapY, int musicNbr, double horizontalScroll, double verticalScroll)
        {
            TilesetNbr = tilesetNbr;
            BG0Nbr = bg0Nbr;
            Transparency = transparency;
            MapX = mapX;
            MapY = mapY;
            MusicNbr = musicNbr;
            HorizontalScroll = horizontalScroll;
            VerticalScroll = verticalScroll;
        }

        public static Header New => new Header(0, 0, 0, 0, 0, 0, 0, 0);
    }
}
