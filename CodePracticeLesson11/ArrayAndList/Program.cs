using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            List<int> list = new List<int>();
            arr[0] = 1;
            list.Add(1);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr.ElementAt(0));
            Console.WriteLine(list[0]);
            Console.WriteLine(list.ElementAt(0));

            arr[0] = default(int);
            list.RemoveAt(0);
            Console.WriteLine(arr[0]);
            //Console.WriteLine(list[0]);

          
        }
    }
}
