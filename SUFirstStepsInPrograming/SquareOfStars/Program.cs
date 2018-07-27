using System;

namespace SquareOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char star = '*';
            char space = ' ';

            //First Line Of Stars
            for (int i = 0; i < n; i++)
            {
                Console.Write(star);
            }
            Console.WriteLine();

            //Midle Lines Of Stars
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(star);
                for (int j = 0; j < n-2; j++)
                {
                    Console.Write(space);
                }
                Console.Write(star);
                Console.WriteLine();
            }

            //Last Line Of Stars
            for (int i = 0; i < n; i++)
            {
                Console.Write(star);
            }
            Console.WriteLine();
        }
    }
}
