using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Cat : Animal
    {
        public string Breed { get; set; }

        public Cat(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override void Eat()
        {
            Console.WriteLine("I am eating cat food");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
