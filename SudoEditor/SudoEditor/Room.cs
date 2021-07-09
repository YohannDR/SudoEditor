using System;
using System.IO;

namespace SudoEditor
{
    public class Room
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public Header Header { get; set; }

        public Room(bool isNew, int id, int area)
        {
            ID = id;
            AreaID = area;
            AreaName = Area.Areas[AreaID].Nom;
            if (isNew)
            {
                File.Create(Settings.AreaPath + AreaName + "/" + ID + ".room").Close();
                Header = Header.New;
            }
            else
            {
                Header = Header.New;
            }
        }

        public void Save()
        {
            
        }
    }
}
