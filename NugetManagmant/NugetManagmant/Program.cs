using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SortingGeneric;

namespace NugetManagmant
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Product> products=new List<Product>();
            products.Add(new Product{Id = 1,Name = "Laptop",Price = 1500000});
            products.Add(new Product{Id = 2,Name = "mouse",Price = 1500});
            var serializeObject = JsonConvert.SerializeObject(products,Formatting.Indented);
            Console.WriteLine(serializeObject);
        }
    }
}
