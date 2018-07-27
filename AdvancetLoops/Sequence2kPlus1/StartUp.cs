using System;

namespace Sequence2kPlus1
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n;)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}
