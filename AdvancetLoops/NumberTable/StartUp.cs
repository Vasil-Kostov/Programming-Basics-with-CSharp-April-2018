using System;

namespace NumberTable
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n)
                    {
                        Console.Write(j + i + 1);
                    }
                    else
                    {
                        Console.Write(2 * n - (j + i + 1));
                    }
                    if (j < n - 1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
