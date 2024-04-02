using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class SecurityCloset : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"You are in the Security Closet.
Behind you, there is the [lobby].
You see a [desk] with stuff on it.
"; // desk has keycard for elevator

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "lobby":
                    Console.WriteLine("You return to the lobby and close the door behind you.");
                    Game.Transition<Lobby>();
                    break;
                case "desk":
                    Console.WriteLine("The desk has a [clipboard], a [sticky note], and a [computer].");

                    isKeyCollected = true;

                    switch (choice)
                    {
                        case "clipboard":
                            break;
                        case "sticky note":
                            break;
                        case "computer":
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
