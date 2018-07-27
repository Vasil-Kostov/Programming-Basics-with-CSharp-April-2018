using System;

namespace DiamondsOfStars
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                if (i != n)
                {
                    for (int l = 0; l < i; l++)
                    {

                        Console.Write(" *");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int l = 0; l < i -1; l++)
                    {
                      
                        Console.Write(" *");
                    }
                }
                for (int y = 1; y < n - i; y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < j; i++)
                {
                    Console.Write(" ");
                }
                for (int l = n; l > j; l--)
                {

                    Console.Write(" *");
                }
                for (int i = 1; i < j; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
