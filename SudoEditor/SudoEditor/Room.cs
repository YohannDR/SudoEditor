using System.IO;

namespace SudoEditor
{
    public class Room
    {
        public int ID;
        public string Area;
        public Header Header;

        public Room(bool isNew, int id, string area)
        {
            if (isNew)
            {
                File.Create(Settings.AreaPath + area + "/" + id + ".room").Close();
            }
            else
            {

            }
            ID = id;
            Area = area;
            Header = new Header();
        }

        public void Save()
        {
            
        }
    }
}
