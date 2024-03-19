using System;

namespace NarrativeProject.Rooms
{
    internal class Bathroom : Room
    {

        internal override string CreateDescription() =>
@"In your bathroom, you want to take a [bath].
The [mirror] in front of you reflects your depressed face.
You can return to your [bedroom].
";
        internal static bool bathTaken;
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bath":
                    Console.WriteLine("You turn on the bath and relax in the warmth of the water.");
                    bathTaken = true;
                    break;
                case "mirror":
                    if (!bathTaken)
                    {
                        Console.WriteLine("You see your greasy hair and want to take a bath.");
                    }
                    else
                    {
                        Console.WriteLine("You see the numbers 6969 written on the fog on your mirror.");
                    }
                    break;
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
