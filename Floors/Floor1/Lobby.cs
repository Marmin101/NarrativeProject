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
                    Console.WriteLine("You approach the door to the outside.");
                    Game.Transition<Outside>();
                    break;
                case "door":
                    if (!SecurityCloset.isKeyCollected)
                    {
                        Console.WriteLine("The door is locked.");
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
