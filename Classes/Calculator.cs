using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Calculator
    {

        public int total = 0;

        public int Add(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }
    }
}
