using System;

namespace NarrativeProject.Floors.Floor2
{
    internal class Corridor : Room
    {
        internal override string CreateDescription() =>
@"You are on Floor 2 in a narrow, yet long, corridor.
Right behind you, there is the [elevator].

On the wall there is a [poster], but it is too far to read. // under the poster theres a table with a phone that when u call it it plays a voicemail with a room number

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
                    Console.WriteLine
                    (@"You walk up to the poster and read it. 
                    It displays an image of an oak tree with a clear blue sky behind it and green grass at its roots.
                    At the bottom of the poster, it is written [random number].

                    Beneath the poster and against the wall, you find a small table with a [telephone] on it.");
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
