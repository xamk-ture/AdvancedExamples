using System.ComponentModel.DataAnnotations;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alustetaan Animal tyyppisiä olioita
            var dog = new Dog("Fido", 5, "Golden Retriever");
            dog.Speak();

            var fish = new Fish("Nemo", 1, "Orange");
            fish.Speak();

            var cat = new Cat("Garfield", 3, "Tabby");
            cat.Speak();

            //Alustetaan Animal tyyppinen lista, johon laitetaan eri eläinlajeja
            var animals = new List<Animal> { dog, fish, cat };

            //Iteroidaan kaikki eläimet ja laitetaan ne syömään
            foreach (var animal in animals)
            {
                animal.Eat();
            }
        }
    }
}