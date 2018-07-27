using System;

namespace DrawFort
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('/', 1) + new string('^', n / 2) + new string('\\', 1) +
                new string('_', 2 * n - 2 * ( n / 2) - 4) + new string('/', 1) +
                new string('^', n / 2) + new string('\\', 1));
            Console.WriteLine();
            
            for (int i = 0; i < n - 2; i++)
            {
                if (i != n - 3)
                {
                    Console.Write(new string('|', 1) + new string(' ', n / 2 + 1) +
                        new string(' ', 2 * n - 2 * (n / 2) - 4) + new string(' ', n / 2 + 1) + new string('|', 1));
                }
                else
                {
                    Console.Write(new string('|', 1) + new string(' ', n / 2 + 1) +
                        new string('_', 2 * n - 2 * (n / 2) - 4) + new string(' ', n / 2 + 1) + new string('|', 1));
                }
                Console.WriteLine();
            }
            
            Console.Write(new string('\\', 1) + new string('_', n / 2) + new string('/', 1) +
                new string(' ', 2 * n - 2 * (n / 2) - 4) + new string('\\', 1) +
                new string('_', n / 2) + new string('/', 1));
        }
    }
}
