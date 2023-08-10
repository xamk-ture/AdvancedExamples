using System.ComponentModel.DataAnnotations;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Fido", 5, "Golden Retriever");
            dog.Speak();

            var fish = new Fish("Nemo", 1, "Orange");
            fish.Speak();

            var cat = new Cat("Garfield", 3, "Tabby");
            cat.Speak();

            var animals = new List<Animal> { dog, fish, cat };

            foreach (var animal in animals)
            {
                animal.Eat();
            }
        }
    }
}