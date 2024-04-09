using System;

namespace NarrativeProject.Floors.Floor2
{
    internal class Poster : Room
    {
        internal override string CreateDescription() =>
$@"The poster displays an image of an oak tree with a clear blue sky behind it and green grass at its roots.
At the bottom of the poster, it is written {posterNum} in black ink. It seems to be freshly written...
Beneath the poster and against the wall, you find a small table with a [telephone] on it.
Or, you could walk back to the [corridor].
";
        internal static int posterNum = new Random().Next(100, 999);

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "corridor":
                    Console.WriteLine("You return to the corridor.");
                    Game.Transition<Corridor>();
                    break;
                case "telephone":
                    Console.WriteLine("You pick up the phone and hear the dial tone.");
                    Game.Transition<Telephone>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }
}
