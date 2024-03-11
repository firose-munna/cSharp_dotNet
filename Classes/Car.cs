using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {

        private string _carName = "BMW";
        private string _carModel = "BMW12221";
        private string _carColor = "red";
        private int _carPrice = 185555444;

        public void carInfo()
        {
            Console.WriteLine("Name of the Car is : {0}", _carName);
            Console.WriteLine("Name of the Car Model is : {0}", _carModel);
            Console.WriteLine("Name of the Car Color is : {0}", _carColor);
            Console.WriteLine("Price of the Car is : {0}", _carPrice);
        }

    }
}
