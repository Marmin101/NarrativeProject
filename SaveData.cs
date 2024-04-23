using System;
using System.Collections.Generic;
using System.IO;


namespace NarrativeProject
{
    [Serializable]
    internal class SaveSystem
    {



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
