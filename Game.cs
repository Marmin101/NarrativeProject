using System;
using System.Collections.Generic;

namespace NarrativeProject
{
    internal class Game
    {
        List<Room> rooms = new List<Room>();
        Room currentRoom;

        public static List<string> inventory = new List<string>();

        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        public static int energy = 100;

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "save":
                    SaveGame();
                    break;
                case "load":
                    LoadGame();
                    break;
                default:
                    currentRoom.ReceiveChoice(choice);
                    CheckTransition();
                    break;
            }
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
            energy -= 5;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal static void Energy()
        {
            if (Game.energy > 100)
            {
                Game.energy = 100;
            }
            if (Game.energy <= 0)
            {
                Console.Clear();
                Game.energy = 0;
                Console.WriteLine("ENERGY: " + energy);
                Console.WriteLine("--");
                Console.WriteLine("You have run out of energy.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Game.Finish();
                Console.WriteLine("Game over.\nPress Enter to exit.");
            }
        }

        public static void AddItem(string item)
        {
            inventory.Add(item);
            Console.WriteLine("(+ " + item + ")");
        }
        public static void RemoveItem(string item) 
        { 
            if (inventory.Contains(item))
            {
            inventory.Remove(item); 
            Console.WriteLine("(- " + item + ")");
            }
        }
        public static void ShowInventory()
        {
            Console.WriteLine("INVENTORY\n---------");
            if (inventory.Count > 0)
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine(" * " + inventory[i]);
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }

        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }

        internal static void SaveGame<T>() where T : Room
        {
            throw new NotImplementedException();
        }

        public void SaveGame()
        {
            Console.WriteLine(currentRoom.GetType().Name); // Current room
            Console.WriteLine(energy); // Energy
            foreach (var item in inventory) // All inventory items
            {
                Console.WriteLine(item);
            }
        }

        public void LoadGame()
        {
            ygby7gby7b7bt7b7
        }
    }
}
