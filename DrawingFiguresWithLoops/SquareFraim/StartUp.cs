using System;

namespace SquareFraim
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write('+');
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int j = 0; j < n-2; j++)
            {
                Console.Write('|');
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

            Console.Write('+');
            for (int l = 0; l < n - 2; l++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
