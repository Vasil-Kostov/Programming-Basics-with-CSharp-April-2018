using System;

namespace Butterfly
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2) + '\\' + ' ' + '/' + new string('*', n -2));
                }
                else
                {
                    Console.Write(new string('-', n - 2) + '\\' + ' ' + '/' + new string('-', n - 2));
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string(' ', n - 1) + '@' + new string(' ', n - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2) + '/' + ' ' + '\\' + new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2) + '/' + ' ' + '\\' + new string('-', n - 2));
                }
                Console.WriteLine();
            }
        }
    }
}
