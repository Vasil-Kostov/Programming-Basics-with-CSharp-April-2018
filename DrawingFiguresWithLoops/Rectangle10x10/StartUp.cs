using System;

namespace Rectangle10x10
{
    class StartUp
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
