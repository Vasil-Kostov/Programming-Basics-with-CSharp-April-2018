using System;

namespace ChristmasTree
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(' ');
                }
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                for (int j = n; j > i; j--)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
