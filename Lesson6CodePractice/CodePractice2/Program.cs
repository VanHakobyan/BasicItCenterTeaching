using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice2
{
    public class Person
    {
        public string name { get; set; }
    }
    class Program
    {
        public static void ChangeName(ref string name)
        {
            name = name.Substring(0, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input any name");
            string name = Console.ReadLine();
            ChangeName(ref name);
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
