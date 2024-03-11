using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class Car
    {
        public string name;
    }
    public class Car2 : Car {
        public string model;
    }
    public class Car3 : Car2
    {
        public void showDetails()
        {
            Console.WriteLine("Name of the Car : {0}", name);
            Console.WriteLine("Model Name of the Car : {0}", model);
        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            var carObj = new Car3();

            carObj.name = "BMW";
            carObj.model = "B12323";
            carObj.showDetails();





            Console.ReadLine();
        }
    }
}
