using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
 
        }

        public virtual void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public virtual void Speak()
        {
            Console.WriteLine("I am sleeping");
        }
    }
}
