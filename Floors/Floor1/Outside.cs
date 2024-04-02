using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Outside : Room
    {

        internal override string CreateDescription() =>
@"You are outside.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Lobby>();
                    break;
                case "couch":
                    Console.WriteLine("You sit on the couch and fall asleep.");
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
