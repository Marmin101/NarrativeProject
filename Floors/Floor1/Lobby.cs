using System;
using System.Net;
using System.Security.Cryptography;

namespace NarrativeProject.Floors.Floor1
{
    internal class Lobby : Room
    {

        internal override string CreateDescription() =>
@"You are in the lobby.
Behind the front desk on your right, there is a [door].
In the back, you see an [elevator].
Behind you, there is the front door leading [outside].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "outside":
                    // must collect key to outside to escape the building. key location tbd, somewhere on floor 2.
                    if (Elevator1.outsideKeyTaken /*this is just a placeholder for testing purposes*/)
                    {
                        Console.WriteLine("You insert the key and twist. The door unlocks, you step outside.");
                        Game.Transition<Outside>();
                    }
                    else if (!Elevator1.outsideKeyTaken && FrontDesk.securityKeyTaken)
                    {
                        Console.WriteLine("You try inserting that key you found at the front desk.");
                        Console.WriteLine("Strangely, it does not fit the lock. Perhaps there's another key somewhere else?");
                    }
                    else if (!Elevator1.outsideKeyTaken)
                    {
                        Console.WriteLine("The door to go outside is locked. Maybe there's a key somewhere in this building to open it?");
                    }
                    break;
                case "door":
                    if (!FrontDesk.securityKeyTaken)
                    {
                        Console.WriteLine("You approach the front desk and try opening the door behind it, but it is locked.");
                        Game.Transition<FrontDesk>();
                    }
                    else
                    {
                        Console.WriteLine("You open the door with the shiny silver key and enter the security closet.");
                        Game.Transition<SecurityCloset>();
                    }
                    break;
                case "elevator":
                    Console.WriteLine("You approach the elevator.");
                    Game.Transition<Elevator1>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
