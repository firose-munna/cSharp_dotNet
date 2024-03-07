using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            Console.WriteLine("Current DateTime is : "+ now);

            Console.WriteLine("Hour : " + now.Hour);
            Console.WriteLine("Minutes : " + now.Minute);

            Console.WriteLine("Custom formate : " + now.ToString("dd.MM.yyyy"));
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());


            var tomorrow = now.AddDays(1);
            Console.WriteLine(tomorrow);

            var newdate = new DateTime(2024, 3, 7);
            newdate.AddYears(1);

            Console.WriteLine(newdate.Year);

            Console.WriteLine(TimeSpan.FromHours(1));

            Console.ReadLine();  
        }
    }
}
