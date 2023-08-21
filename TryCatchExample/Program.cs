namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kokonaisluku:");

            // Luetaan syöte käyttäjältä.
            string userInput = Console.ReadLine();

            try
            {
                // Yritetään muuttaa syöte kokonaisluvuksi.
                int number = int.Parse(userInput);
                Console.WriteLine($"Syöttämäsi luku on: {number}");
            }
            catch (FormatException exception)
            {
                // Tämä osio suoritetaan, jos yllä oleva koodi aiheuttaa FormatException-virheen.
                //Huomaa, että Exception tyyppejä on useampi ja pyri käyttäämään relevanttia tyyppiä, jotta kerrot muille koodareille koodisi tarkoituksen paremmin
                Console.WriteLine("Annettu syöte ei ollut kelvollinen kokonaisluku.");

                //exception muuttujasta voidaan löytää tarkempi syy miksi ohjelma kaatui
                Console.WriteLine(exception.Message);

                //Muista, että muuttuja sisältää monia muitai tietoja, josta saa vieläkin tarkempaa tietoa, kuten stack trace
                Console.WriteLine(exception.StackTrace);
            }
            finally // finally osio on valinnainen
            {
                // Tämä osio suoritetaan aina, riippumatta siitä, tuliko virheitä vai ei.
                Console.WriteLine("Tämä suoritetaan aina!");
            }
        }
    }
}