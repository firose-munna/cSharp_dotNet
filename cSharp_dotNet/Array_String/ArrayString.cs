using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_dotNet.Array_String
{
     internal class ArrayString
    {
        int[] numbers = new int[5] { 1, 2, 5, 6, 8 };
        
          public void ShowNumbers()
        {
            Console.WriteLine("Showing The Numbers By New Line -");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
        }

        string[] names = new string[3] {"Firose", "Mahmud", "Munna"};

        
    }
}
