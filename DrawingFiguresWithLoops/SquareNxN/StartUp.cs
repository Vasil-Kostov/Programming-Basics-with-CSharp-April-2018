using System;

namespace SquareNxN
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //if (i % 2 != 0)
                //{
                    for (int j = 1; j < n*2; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                //}
                //else
                //{
                //    for (int l = 1; l < n*2; l++)
                //    {
                //        Console.Write(" ");
                //    }
                //    Console.WriteLine();
                //}

            }
        }
    }
}
