using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Animal
    {
        public string Name;
        public int age;
        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
    }
}
