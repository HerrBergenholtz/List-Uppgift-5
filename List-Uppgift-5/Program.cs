using System;

namespace Uppgift_5
{
    class Program
    {
        static void Main()
        {
            List<int> löner = new();

            int input = 1;
            Console.WriteLine("Skriv in löner, avlsuta med att skriva in 0");

            while (input != 0)
            {
                Console.WriteLine();
                Console.Write("Lön: ");
                input = int.Parse(Console.ReadLine());

                if (input > 0) löner.Add(input);
                else break;
            }

            Console.WriteLine($"Medellönen är: {Medel(löner)}");
            Console.WriteLine($"Medianlönen är: {Median(löner)}");

            Console.ReadKey();
        }

        static float Medel(List<int> löner)
        {
            int sum = 0;

            for (int i = 0; i < löner.Count; i++)
            {
                sum += löner[i];
            }

            return (float) sum / löner.Count;
        }

        static float Median (List<int> löner)
        {
            if (löner.Count % 2 == 0)
            {
                return (float) (löner[löner.Count / 2] + löner[löner.Count / 2 - 1]) / 2;
            }
            else
            {
                return löner[löner.Count / 2];
            }
        }
    }
}