using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface Animal
    {
        void doing();
    }

    class Dog : Animal
    {
        public void doing()
        {
            Console.WriteLine("Dog is barking Gheu gheu");
        }
    }
    class Cat : Animal
    {
        public void doing()
        {
            Console.WriteLine("Cat makes a sound meu meu");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var dog = new Dog();
            var cat = new Cat();

            dog.doing();
            cat.doing();

            Console.ReadLine();
        }
    }
}
