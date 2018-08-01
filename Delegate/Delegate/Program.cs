using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate int del(int i);

        static void Main(string[] args)
        {
            del myDelegate = y => y * y;
            del myDelegate2 = Mul;
            int j = myDelegate(5);
            Console.WriteLine(j);
            Console.ReadLine();

        }
        public static int Mul(int i)
        {
            return i * i;
        }
    }
}
