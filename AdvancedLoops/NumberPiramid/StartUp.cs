using System;

namespace NumberPiramid
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            var j = 0;
            var count = 1;
            for (int i = 0; i + j <= n; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(count);
                    if (j !=i)
                    {
                        Console.Write(' ');
                    }
                    count++;
                    if (count == n + 1)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
