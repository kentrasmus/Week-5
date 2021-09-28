using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string username = Console.ReadLine();
                Console.WriteLine("sisesta parool:");
                string userPassword = Console.ReadLine(); 

                if(username == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäämud.");
                }
            }
        }
    }
}
