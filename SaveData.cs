using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using NarrativeProject.Floors.Floor1;
using NarrativeProject.Floors.Floor2;

namespace NarrativeProject
{
    [Serializable]
    internal class SaveSystem
    {

        public Game gameSave { get; set; }
        public Floors.Floor1.Lobby lobbySave { get; set; }
        public Floors.Floor1.Elevator1 elevator1Save { get; set; }
        public Floors.Floor1.FrontDesk frontDeskSave { get; set; }
        public Floors.Floor1.Outside outsideSave { get; set; }
        public Floors.Floor1.SecurityCloset securityClosetSave { get; set; }
        public Floors.Floor2.AccessRoom accessRoomSave { get; set; }
        public Floors.Floor2.Corridor corridorSave { get; set; }
        public Floors.Floor2.Elevator2 elevator2Save { get; set; }
        public Floors.Floor2.Poster posterSave { get; set; }
        public Floors.Floor2.Telephone telephoneSave { get; set; }


        const string saveFile = "SaveData.txt";
        public static void Save()
        {
            if (!File.Exists(saveFile))
            {
                File.Create(saveFile).Close();
            }
            File.WriteAllText(saveFile, "NarrativeProject Save Data");
        }
        public static void Load()
        {
            if (!File.Exists(saveFile))
            {
                Console.WriteLine("No save data found.");
                return;
            }
            else if (File.Exists(saveFile))
            {
                Console.WriteLine("Save data found.");
                File.ReadAllText(saveFile);
            }
        }
    }
}
