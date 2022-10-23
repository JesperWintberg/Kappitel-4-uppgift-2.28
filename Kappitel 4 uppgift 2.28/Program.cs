using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din mening");
            string mening = Console.ReadLine();
            Console.WriteLine("Skriv in två bokstäver");
            string bok = Console.ReadLine();
 

            if (mening.Contains(bok))
            {
                Console.WriteLine("Din mening innerhåller dinna två ord");
            }
            else
            {
                Console.WriteLine("Din mening innerhåller inte dinna två ord");
            }
           

        }
    }
}

