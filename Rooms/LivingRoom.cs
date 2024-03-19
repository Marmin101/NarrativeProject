using System;

namespace NarrativeProject.Rooms
{
    internal class LivingRoom : Room
    {

        internal override string CreateDescription() =>
@"In the living room, you see a [couch].
Behind you, there is your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
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
