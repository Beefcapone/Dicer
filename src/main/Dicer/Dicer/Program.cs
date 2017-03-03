using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rand = new Random();
            Console.WriteLine("Tryk enter for at rulle terning, Tryk esc for at exit!");
            while (true)
            {                
                ConsoleKeyInfo keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Tryk enter for at rulle terning, Tryk esc for at exit!");
                    Console.WriteLine(rand.Next(5) + 1);                    
                }
                else if (keyPress.Key == ConsoleKey.Escape) break;
            }
        }
    }
}
