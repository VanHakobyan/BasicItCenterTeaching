using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 50;
            Console.WriteLine(number2++);//50
            Console.WriteLine(number1--);//10

            Console.WriteLine(number2);//51
            Console.WriteLine(number1);//9

            Console.WriteLine(++number2);//52
            Console.WriteLine(--number1);//8


            Console.WriteLine(number2);//52
            Console.WriteLine(number1);//8
        }
    }
}
