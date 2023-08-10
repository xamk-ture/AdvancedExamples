using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override void Eat()
        {
            Console.WriteLine("I am eating dog food");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
