using System;

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
                    // must collect key to outside to escape the hotel. key location tbd, somewhere on floor 6.
                    if (true /*key to outside is not collected*/)
                    {
                        Console.WriteLine("The door to go outside is locked. Maybe there's a key somewhere in this building to open it?");
                    }
                    else
                    {
                        Console.WriteLine("You insert the key and twist. The door unlocks, you step outside.");
                        Game.Transition<Outside>();
                    }
                    break;
                case "door":
                    if (!FrontDesk.securityKeyTaken) // if the security key is not collected
                    {
                        Console.WriteLine("You approach the front desk and try opening the door behind it, but it is locked.");
                        Game.Transition<FrontDesk>();
                    }
                    else
                    {
                        Console.WriteLine("You open the door with the key and enter the security closet.");
                        Game.Transition<SecurityCloset>();
                    }
                    break;
                case "elevator":
                    Console.WriteLine("You approach the elevator.");
                    Game.Transition<Elevator>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
