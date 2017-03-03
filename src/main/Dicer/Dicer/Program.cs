using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicer
{
    class Program
    {
        static int numDice = 1;
        static Boolean running = true;
        static string def1 = "Press Enter to roll, M for Menu and Esc for exit!";

        static void Main(string[] args)
        {
            Random rand = new Random();
            
            Console.Clear();
            Console.WriteLine(def1);

            while (running)
            {                
                ConsoleKeyInfo keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine(def1);
                    for (int i = 0; i < numDice; ++i)
                    {
                        Console.WriteLine("Terning " + (i + 1) + " " + (rand.Next(5) + 1));
                    }
                }
                else if (keyPress.Key == ConsoleKey.M) Menu();
                //Q = Esben Syndrome!
                else if (keyPress.Key == ConsoleKey.Escape || keyPress.Key == ConsoleKey.Q) running = false;
            }
        }

        static void Menu()
        {
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Press backspace to go back or esc to exit..");
               
                Console.WriteLine("Number of dice: " + numDice);

                ConsoleKeyInfo keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.RightArrow)
                {
                    ++numDice;
                }
                else if (keyPress.Key == ConsoleKey.LeftArrow)
                {
                    --numDice;
                    numDice = Math.Max(numDice, 1);
                    // if (numDice < 1) numDice = 1;                   
                }
                else if (keyPress.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Console.WriteLine(def1);
                    break;
                }
                else if (keyPress.Key == ConsoleKey.Escape || keyPress.Key == ConsoleKey.Q) running = false;
            }
        }
    }
}
