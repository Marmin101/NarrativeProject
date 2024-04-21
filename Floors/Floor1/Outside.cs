using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Outside : Room
    {

        internal override string CreateDescription() => "You are outside. Finally, the taste of fresh air.\n\nYou win!\n\n\n\n\n\n\n\n\nPress enter to exit.";

        internal override void ReceiveChoice(string choice)
        {
            { 
                    Game.Finish();
            }
        }
    }
}
