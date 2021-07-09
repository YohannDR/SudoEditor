using System;
using System.IO;
using System.Collections.Generic;

namespace SudoEditor
{
    public class Area
    {
        public static List<Area> Areas = new List<Area>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public int ID { get; set; }
        public string Nom { get; set; }

        public Area(string Name, bool isNew, int nbrSalles = 1)
        {
            Nom = Name;
            Areas.Add(this);
            ID = Areas.Count - 1;
            if (isNew)
            {
                Directory.CreateDirectory(Settings.AreaPath + Nom);
                for (int i = 0; i < nbrSalles; i++) { Rooms.Add(new Room(true, i, ID)); }
            }
            else
            {
                for (int i = 0; i < Directory.GetFiles(Settings.AreaPath + Nom).Length; i++) Rooms.Add(new Room(false, i, ID));
            }
        }

        public void AjouterSalle()
        {
            Rooms.Add(new Room(true, Rooms.Count, ID));
        }
    }
}