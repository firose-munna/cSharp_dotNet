using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Operations : ");
            var numbers = new[] { 1, 2, 8, 6, 7 };

            Console.Write("Element of the Numbers Array : " );
            foreach( var number in numbers )
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Length of the Numbers Array : " + numbers.Length);

            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("The index no of 6 is : " + index);


            var newNumbers = new int[3];

            Array.Copy(numbers, newNumbers, 3);

            Console.Write("The New Array Elements after copy Are : ");
            foreach( var number in newNumbers ) {
                Console.Write(number + " ");
            }

            Array.Clear(newNumbers, 0, 2);

            Console.WriteLine();
            Console.Write("The New Array Elements After clear Are : ");
            foreach (var number in newNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Array.Sort(numbers);
            Console.Write("Element of the Numbers Array after sort : ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Array.Reverse(numbers);
            Console.Write("Element of the Numbers Array after reverse : ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List operations : ");

            var list  = new List<int>() { 5,6,3,8};
            Console.Write("Initial List : ");
            foreach(var number in list)
            {
                Console.Write(number + " ");
            }

            list.Add(10);
            Console.WriteLine();
            Console.Write("After Add in the List : ");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }

            list.AddRange(numbers);
            Console.WriteLine();
            Console.Write("After AddRange in the List : ");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }


            list.AddRange(new int[3] { 96, 88, 45 });
            Console.WriteLine();
            Console.Write("After AddRange in the List : ");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }

            list.Sort();



            Console.ReadLine();
        }
    }
}
