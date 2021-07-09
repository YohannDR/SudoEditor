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

        public Header(int tilesetNbr, int bg0Nbr, double transparency, int mapX, int mapY, int musicNbr) => (TilesetNbr, BG0Nbr, Transparency, MapX, MapY, MusicNbr) = (tilesetNbr, bg0Nbr, transparency, mapX, mapY, musicNbr);

        public static Header New => new Header(0, 0, 0, 0, 0, 0);
    }
}
