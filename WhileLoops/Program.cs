using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            // programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab"Tere tulemast!"
            //kui sisestatud PIN-kood on midagi muud, konsool kuvab"vale PIN. Proovi uuesti."
            //tingimus 1. katsete arv on piiramatu
            // tingimus 2. kasutajal on kolm katset

            /*
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Hello World");

                i = i + 1;


            }
            Console.WriteLine("Kena Päeva");
            */
            /*
            while (true)
            {
                Console.WriteLine("sisesta PIN-kood");
                int userpin = Convert.ToInt32(Console.ReadLine());

                if(userpin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti lol.");
                }

                Console.WriteLine("Kena päeva");

            }
            */
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("sisesta PIN-kood");
                int userpin = Convert.ToInt32(Console.ReadLine());
                if(userpin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i}  katset on jäänud.");
                }
            }
        }
    }
}
