using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Elevator1 : Room
    {

        internal override string CreateDescription() =>
@"In the elevator, there are buttons to visit floor [1] and floor [2].
Which floor will you visit? (You are on floor 1)
";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "i":
                    Game.ShowInventory();
                    break;
                case "1":
                    Console.WriteLine("You return to the lobby.");
                    Game.Transition<Lobby>();
                    break;
                case "2":
                    if (SecurityCloset.elevatorPass)
                    {
                        Console.WriteLine("You enter the second floor.");
                        Game.Transition<Floor2.Corridor>();
                    }
                    else
                    {
                        Console.WriteLine("The elevator requires a keycard to access the second floor.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
