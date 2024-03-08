using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }
    }
    class Student
    {
        string name = "Firose Munna";
        int age = 23;
        string address = "Mirpur 2";

        public void showDetails()
        {
            Console.WriteLine("Hello Everyone. I am {0}. I am {1} years old. I am coming from {2}.", name, age, address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the intermediate course of c# from Udemy.com");

            var firose = new Student();

            firose.showDetails();

            Console.WriteLine();
            Console.WriteLine("This is the another class.");

            var p1 = new Person();
            p1.Name = "Firose Munna";
            p1.Introduce("Arafat");


            Console.WriteLine();
            Console.WriteLine("Constructor Method : ");

            var petName = new Animal("Lion");

            Console.WriteLine("name of the Animal is : "+ petName.Name);


            Console.WriteLine();
            Console.WriteLine("This is function overloading....");

            var pet1 = new Animal("Tiger");
            Console.WriteLine("1st constructor is called : Name : {0} and Age : {1}", pet1.Name, pet1.age );

            var pet2 = new Animal("Cow", 45);

            Console.WriteLine("The Second Constructor is called. Animal Name is : {0} and Age is : {1}", pet2.Name, pet2.age);


            //This is for point class....
            Console.WriteLine();

            Console.WriteLine("This is for point class");

            var location1 = new Point(4,10);
            Console.WriteLine("After diclare the constructor then the value of X is {0} and the Value of Y is : {1}", location1.x, location1.y);

            location1.Move(45, 89);
            Console.WriteLine("After Call the Move method with pass the value then Value of X is {0} and the value of Y {1}", location1.x, location1.y);


            location1.Move(new Point(788, 77));

            Console.WriteLine("After pass the constructor using Move Method then the X value is : {0} and the value of Y is : {1}", location1.x, location1.y);


            //This the array elements calculator....
            Console.WriteLine();
            Console.WriteLine("Array Elements Calculator....");

            var cal = new Calculator();

            Console.WriteLine("Total value is : {0}", cal.Add(4,5,6));
            Console.WriteLine("Total value is : {0}", cal.Add(4, 5, 6, 7, 9));

            //This is for setter and getter...
            Console.WriteLine();
            Console.WriteLine("Setter and getter method to access the private property of a class-");

            var num = new SetAndGet();
            num.setNumber(15);
            Console.WriteLine("After Set the Number of the private variable then the number is : {0}", num.getNumber());


            //this is for set the private variable using user input....
            Console.Write("Enter a number to set the private value of the SetAndGet class.... : ");
            var userNumber = Convert.ToInt32(Console.ReadLine());

            num.setNumber(userNumber);

            Console.WriteLine("After seeting the private number from user input then the number is : {0}", num.getNumber());

            Console.ReadKey();  
        }
    }
}
