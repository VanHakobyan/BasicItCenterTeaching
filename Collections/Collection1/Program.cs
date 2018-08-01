using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[37];
            arr[0] = 125;
            arr[36] = 15;
            int[] more10 = arr.Where(x => x > 10).ToArray();


            List<string> subList = new List<string>();
            subList.Add("new item");

            List<string> strList = new List<string>();

            strList.Add("15");
            strList.Add("16");
            strList.Add("17");

            strList.AddRange(subList);

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
