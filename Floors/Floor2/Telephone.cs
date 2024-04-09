using System;
using System.Management.Instrumentation;

namespace NarrativeProject.Floors.Floor2
{
    internal class Telephone : Room
    {
        internal override string CreateDescription() =>
@"You hear the dial tone of the telephone.
[Hang up]? (goes back to the corridor)
";        

        internal override void ReceiveChoice(string choice)
        {
            if (choice == Poster.posterNum.ToString())
            {
                Console.WriteLine("You enter the number you found on the poster. You hear the ringing tone.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("It rings. ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("It rings some more. ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("And more.");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("You hear a click and a muffled voice answers.");
                Console.WriteLine('"' + "I've left you a gift." + '"');

            }
            else
            {
                switch (choice)
                {
                    case "hang up":
                        Console.WriteLine("You return to the corridor.");
                        Game.Transition<Corridor>();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

    }
}
