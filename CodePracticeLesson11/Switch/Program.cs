using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
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
                        Console.WriteLine(DayOfWeek.Monday);
                        break;
                    case 2:
                        Console.WriteLine(DayOfWeek.Tuesday);
                        break;

                    case 3:
                        Console.WriteLine(DayOfWeek.Wednesday);
                        break;

                    case 4:
                        Console.WriteLine(DayOfWeek.Thursday);
                        break;
                    case 5:
                        Console.WriteLine(DayOfWeek.Friday);
                        break;

                    case 6:
                        Console.WriteLine(DayOfWeek.Saturday);
                        break;

                    case 7:
                        Console.WriteLine(DayOfWeek.Sunday);
                        break;
                    default:
                        Console.WriteLine("incorect day of week");
                        break;

                }

                
                
            }

        }
    }
}
