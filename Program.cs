using NarrativeProject.Floors.Floor1;
using NarrativeProject.Floors.Floor2;
using System;

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
            game.Add(new SecurityCloset());
            game.Add(new Outside());
            game.Add(new FrontDesk());

            // Floor 2
            game.Add(new Corridor());
            game.Add(new Elevator2());
            game.Add(new Poster());
            game.Add(new Telephone());

            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
