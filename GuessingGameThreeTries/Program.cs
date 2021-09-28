using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int CpuRandom = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("sisesta number");
                int usersGuess = Convert.ToInt32(Console.ReadLine());
                if (CpuRandom == usersGuess)
                {
                    Console.WriteLine("tubli! oled mängu võitnud");
                    break;
                }
                else
                {
                    i++;

                    Console.WriteLine($"proovi uuesti! {3 - i} katset on jäänud.");
                }
            }
            if(i == 3)
            {
                Console.WriteLine("oled mängu võitnud");

            }
        }                                                           
    }
}
