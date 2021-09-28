using System;

namespace GuessingGameinfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int CpuRandom = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("sisesta number");
                int usersGuess = Convert.ToInt32(Console.ReadLine());
                if(CpuRandom == usersGuess)
                {
                    Console.WriteLine("tubli! oled mängu võitnud");
                    break;
                }
                else
                {
                    Console.WriteLine("proovi uuesti");
                }
            }
            

            
        }
    }
}
