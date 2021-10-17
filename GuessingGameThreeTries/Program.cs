using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri: 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitnud;
            //katsete arv on piiratud 3 katsega, kui kasutaja ei ole suutnud ära arvata, siis mängu võidab arvuti
            //programm genereerib juhusliku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Arva ära number 1-10!");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine($"Palju õnne! {cpuNumber} on õige.");
                    Console.WriteLine("Oled mängu võitnud!");
                    goto Kena;
                }
                else
                {
                    Console.WriteLine($"Vale number. {2 - i} katset jäänud!");
                    i++;
                }
            }
            Console.WriteLine("Mängu võitis arvuti.");
            Kena:
                Console.WriteLine("Kena päeva!");
        }
    }
}
