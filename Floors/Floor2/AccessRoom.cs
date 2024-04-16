﻿using System;

namespace NarrativeProject.Floors.Floor2
{
    internal class AccessRoom : Room
    {
        internal override string CreateDescription() =>
$@"You are in the {Telephone.whichDoor} room. It looks like a hotel room. The lights won't turn on.
You use the light from the corridor to see the room.
You see a [bed], a desk, and a closet.
You can also return to the [corridor].
";
        internal static bool outsideKeyTaken;

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "corridor":
                    Console.WriteLine("You return to the corridor.");
                    Game.Transition<Corridor>();
                    break;
                case "bed":
                    Console.WriteLine("The bed stands out to you, catching a glimpse of a reflective something from the little amount of light entering the room.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("You walk up to the bed and find a gold key.");
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("You take the key.");
                    outsideKeyTaken = true;
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }
}
