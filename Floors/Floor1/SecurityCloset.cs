﻿using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class SecurityCloset : Room
    {
        internal static bool elevatorPass;

        internal override string CreateDescription() =>
@"You are in the Security Closet.
Behind you, there is the [lobby].
You see a [desk] with stuff on it.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "lobby":
                    Console.WriteLine("You return to the lobby and close the door behind you.");
                    Game.Transition<Lobby>();
                    break;
                case "desk":
                    //if (!elevatorPass)
                    if (!Game.inventory.Contains("keycard"))
                    {
                    Console.WriteLine("On the desk, you see a keycard. You decide to take it.");
                    Game.AddItem("keycard");
                    elevatorPass = true;
                    }
                    else
                    {
                        Console.WriteLine("There is nothing on the desk.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

    }
}
