using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int P);
            int.TryParse(Console.ReadLine(), out int O);
            Console.WriteLine();
            for (int i = P; i <= O; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(Math.Abs(O - P) + 1);
            Console.ReadKey();
        }
    }
}
