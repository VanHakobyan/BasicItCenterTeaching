using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int K);

            int sum = 0;
            for (int i = 0; i < K; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
