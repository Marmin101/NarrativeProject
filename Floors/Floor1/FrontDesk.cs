using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject.Floors.Floor1
{
    internal class FrontDesk : Room
    {
        internal override string CreateDescription() =>
@"At the front desk, there is a small [mirror].
You pensively look at the [lobby], ready to clear your head.
Or, you could try opening the [door] again.
";
        internal static bool mirrorMoved;
        internal static bool securityKeyTaken;
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "lobby":
                    Console.WriteLine("You slowly head back to where you started, hitting yourself in the head on the way.");
                    Game.Transition<Lobby>();
                    break;
                case "mirror":
                    if (!mirrorMoved)
                    {
                        Console.WriteLine("You grab the mirror off the desk to inspect your imperfections up closely.");
                        mirrorMoved = true;
                        Console.WriteLine("You place the mirror back on the desk.");
                    }
                    else if (mirrorMoved && !securityKeyTaken)
                    {
                        Console.WriteLine("Beside the mirror, you notice a shiny silver key. You take it.");
                        securityKeyTaken = true;
                    }
                    else
                    {
                        Console.WriteLine("You glance at the mirror on the desk, thanking it for the gift.");
                    }
                    break;
                case "door":
                    if (securityKeyTaken)
                    {
                        Console.WriteLine("You slowly insert the shiny silver key into the door's keyhole and twist 50 degrees clockwise.");
                        Console.WriteLine("You hear a slight click, and the door unlocks.");
                        Game.Transition<SecurityCloset>();
                    }
                    else
                    {
                        Console.WriteLine("The door is still locked.");
                    }
                    break;
            }
        }
    }
}
