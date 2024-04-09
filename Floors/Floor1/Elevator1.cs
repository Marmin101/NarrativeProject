using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Elevator1 : Room
    {

        internal override string CreateDescription() =>
@"In the elevator, there are buttons to visit floor [1] and floor [2].
Which floor will you visit? (You are on floor 1)
";
        internal static bool outsideKeyTaken; // Temporary variable to store if the key was taken from the outside
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You return to the lobby.");
                    Game.Transition<Lobby>();
                    break;
                case "2":
                    Console.WriteLine("You enter the second floor.");
                    Game.Transition<Lobby>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
