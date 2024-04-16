using System;

namespace NarrativeProject.Floors.Floor1
{
    internal class Outside : Room
    {

        internal override string CreateDescription() =>
@"You are outside. Finally, the taste of fresh air.




Enter any key to continue.
";

        internal override void ReceiveChoice(string choice)
        {
            { 
                    Game.Finish();
            }
        }
    }
}
