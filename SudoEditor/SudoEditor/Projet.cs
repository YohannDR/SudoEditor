using System;
using System.IO;
using System.Text;
using System.Drawing;

namespace SudoEditor
{
    public class Projet
    {
        public Projet(bool isNew)
        {
            if (isNew)
            {
                Directory.CreateDirectory(Settings.RessourcesPath + "/Areas");
                Directory.CreateDirectory(Settings.RessourcesPath + "/Areas/Zone 0");
                File.Create(Settings.AreaPath + "Zone 0/0.room").Close();
                Directory.CreateDirectory(Settings.RessourcesPath + "/Tilesets");
                Directory.CreateDirectory(Settings.RessourcesPath + "/Backgrounds");
                File.Create(Settings.RessourcesPath + "/clipdata").Close();
                StreamWriter clipFile = new StreamWriter(Settings.RessourcesPath + "/clipdata", true, Encoding.ASCII, 3);
                clipFile.WriteLine("Air");
                clipFile.Close();

                new Area("Zone 0", true);
            }
            else
            {
                foreach (string area in Directory.EnumerateDirectories(Settings.AreaPath)) new Area(area.Substring(area.Length - (area.Length - Settings.AreaPath.Length)), false);
                foreach (string tileset in Directory.EnumerateFiles(Settings.RessourcesPath + "/Tilesets")) 
                {
                    string[] path = tileset.Split("\\".ToCharArray()[0]);
                    SudoEditor.Tilesets.Add(int.Parse(path[path.Length - 1].Substring(0, path[path.Length - 1].Length - 4)), Image.FromStream(new MemoryStream(File.ReadAllBytes(tileset))));
                }

                foreach (string background in Directory.EnumerateFiles(Settings.RessourcesPath + "/Backgrounds"))
                {
                    string[] path = background.Split("\\".ToCharArray()[0]);
                    SudoEditor.Backgrounds.Add(int.Parse(path[path.Length - 1].Substring(0, path[path.Length - 1].Length - 4)), Image.FromStream(new MemoryStream(File.ReadAllBytes(background))));
                }

                StreamReader clipFile = new StreamReader(Settings.RessourcesPath + "/clipdata");
                while (!clipFile.EndOfStream)
                {
                    SudoEditor.Clipdatas.Add(clipFile.ReadLine());
                }
                clipFile.Close();
            }
        }

        public void Save()
        {
            foreach (Area area in Area.Areas)
            {
                foreach (Room room in area.Rooms) room.Save();
            }
        }

        public void Dispose()
        {
            SudoEditor.Tilesets.Clear();
            SudoEditor.Backgrounds.Clear();
            SudoEditor.Clipdatas.Clear();
            SudoEditor.Musics.Clear();
            foreach (Area area in Area.Areas) area.Rooms.Clear();
            Area.Areas.Clear();
        }
    }
}
