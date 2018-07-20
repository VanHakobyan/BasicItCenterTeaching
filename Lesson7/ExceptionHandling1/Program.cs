using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        public static int Div(int one, int two)
        {
            int res = 0;
            try
            {
                res = one / two;
            }
            catch
            {
                return int.MaxValue;
            }
            finally
            {
                //res--;
            }
            return res;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please inpute first number");
                var first = Console.ReadLine();
                Console.WriteLine("Please inpute second number");
                var second = Console.ReadLine();
                int firstInt, secondInt;
                if (int.TryParse(first, out firstInt) && int.TryParse(second, out secondInt))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    var res = Div(firstInt, secondInt); //res = int.MaxValue;
                    if (res == int.MaxValue)
                    {
                        Console.WriteLine("Please input correct nuber without 0");
                    }
                    else
                    {
                        Console.WriteLine(res); //correct sln
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input correct numbers");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadKey();

        }
    }
}
