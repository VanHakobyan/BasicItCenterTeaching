using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Color.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(Color.Blue);
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Color.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("incorect id week");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            }
        }
    }
}
