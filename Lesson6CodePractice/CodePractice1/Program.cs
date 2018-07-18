using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice1
{
    class Program
    {
        //text is contain only number
        //Return that count item where contain list

        public static int GetItem(string text, List<decimal> list) => list.Count(x => x == decimal.Parse(text));


        static void Main(string[] args)
        {
            List<decimal> list = new List<decimal>();
            Console.WriteLine("Please imput number");
            string text = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            var count = GetItem(text, list);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
