using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracice2
{
    class Program
    {  
        //5
       
        //5
        //25
        //225
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int t);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(t,i));
            }
        }
    }
}
