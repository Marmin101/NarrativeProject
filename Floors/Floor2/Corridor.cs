using System;

namespace NarrativeProject.Floors.Floor2
{
    internal class Corridor : Room
    {
        internal override string CreateDescription() =>
@"You are on Floor 2 in a narrow, yet long, corridor.
Right behind you, there is the [elevator].

On the wall there is a [poster], but it is too far to read. Beneath it, you see a small table with a [telephone].

You see a door to your [left] and a door to your [right].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "elevator":
                    Console.WriteLine("You return to the elevator.");
                    Game.Transition<Elevator2>();
                    break;
                case "poster":
                    Console.WriteLine("You walk up to the poster and read it.");
                    Game.Transition<Poster>();
                    break;
                case "telephone":
                    Console.WriteLine("You walk up to the phone, you pick it up, and hear the dial tone.");
                    Game.Transition<Telephone>();
                    break;
                case "left":
                    break;
                case "right":
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }
}
