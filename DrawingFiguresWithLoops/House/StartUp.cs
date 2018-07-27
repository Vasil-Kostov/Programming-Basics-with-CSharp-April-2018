using System;

namespace House
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', n / 2 - 1 - i));
                    Console.Write(new string('*', 2 + (2 * i)));
                    Console.Write(new string('-', n / 2 - 1 - i));
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    Console.Write(new string('-', n / 2 - i));
                    Console.Write(new string('*', 1 + (2 * i)));
                    Console.Write(new string('-', n / 2 - i));
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
