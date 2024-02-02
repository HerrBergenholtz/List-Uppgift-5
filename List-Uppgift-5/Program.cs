using System;

namespace Uppgift_5
{
    class Program
    {
        static void Main()
        {
            List<int> löner = new();

            int input = 1;

            while (input != 0)
            {
                Console.WriteLine("Skriv in löner, avlsuta med att skriva in 0");
                Console.WriteLine();
                Console.Write("Lön: ");
                input = input ;
            }
        }
    }
}