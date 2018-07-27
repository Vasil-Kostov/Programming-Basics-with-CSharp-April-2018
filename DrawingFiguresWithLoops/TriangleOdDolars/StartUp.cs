using System;

namespace TriangleOdDolars
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (j != i)
                    {
                        Console.Write(" $");
                    }
                    else
                    {
                        Console.Write("$");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
