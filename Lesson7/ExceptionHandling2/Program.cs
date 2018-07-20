using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        public static MyModel SetModel(MyModel myModel, int? carNuber)
        {
            myModel.Id = 4;
            myModel.CarNumber = carNuber;
            myModel.PhoneNumber = "055555555";
            myModel.Name = "Ashot";

            return myModel;
        }
        static void Main(string[] args)
        {
            MyModel myModel = new MyModel();
            var age = Console.ReadLine();
            if (int.TryParse(age, out int number))
            {
                SetModel(myModel, number);
            }
            else
            {
                SetModel(myModel, null);
            }

            Console.WriteLine(myModel.CarNumber);
            Console.ReadKey();

        }
    }
}
