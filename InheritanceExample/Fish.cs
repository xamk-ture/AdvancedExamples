using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Fish : Animal
    {
        public string Color { get; set; }

        public Fish(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public override void Eat()
        {
            Console.WriteLine("I am eating fish food");
        }

        public override void Speak()
        {
            Console.WriteLine("Blub");
        }
    }
}
