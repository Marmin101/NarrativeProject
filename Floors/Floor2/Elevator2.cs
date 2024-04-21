using System;

namespace NarrativeProject.Floors.Floor2
{
    internal class Elevator2 : Room
    {

        internal override string CreateDescription() =>
@"In the elevator, there are buttons to visit floor [1] and floor [2].
Which floor will you visit? (You are on floor 2)
";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "i":
                    Game.ShowInventory();
                    break;
                case "1":
                    Console.WriteLine("You enter the lobby.");
                    Game.Transition<Floor1.Lobby>();
                    break;
                case "2":
                    Console.WriteLine("You return to the second floor.");
                    Game.Transition<Corridor>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
