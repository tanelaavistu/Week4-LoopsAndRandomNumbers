using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri: 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhusliku numbrit vaid ühe korra.'

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Arva ära number 1-10!");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {
                    Console.WriteLine($"Palju õnne! {cpuNumber} on õige!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti!");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
