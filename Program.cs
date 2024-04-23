using NarrativeProject.Floors.Floor1;
using NarrativeProject.Floors.Floor2;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var game = new Game();

            // Floor 1
            game.Add(new Lobby());
            game.Add(new Elevator1());
            game.Add(new FrontDesk());
            game.Add(new Outside());
            game.Add(new SecurityCloset());

            // Floor 2
            game.Add(new AccessRoom());
            game.Add(new Corridor());
            game.Add(new Elevator2());
            game.Add(new Poster());
            game.Add(new Telephone());


            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                Console.WriteLine("ENERGY: " + Game.energy);
                Console.WriteLine("INVENTORY: [i]");
                Console.WriteLine("--");
                Game.Energy();
                string choice = Console.ReadLine().ToLower() ?? "";
                switch (choice)
                {
                    case "save":
                        game.SaveGame();
                        break;
                    case "load":
                        game.LoadGame();
                        break;
                }
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
        }
    }
}
