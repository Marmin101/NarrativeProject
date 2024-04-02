using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Elevator : Room
    {

        internal override string CreateDescription() =>
@"In the elevator, you see an array of floor levels 1 to 6.
Which floor will you visit?
";
        internal static bool bathTaken;
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You return to the lobby.");
                    bathTaken = true;
                    break;
                case "2":
                    if (!bathTaken)
                    {
                        Console.WriteLine("You see your greasy hair and want to take a bath.");
                    }
                    else
                    {
                        Console.WriteLine("You see the numbers 6969 written on the fog on your mirror.");
                    }
                    break;
                case "3":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Lobby>();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
