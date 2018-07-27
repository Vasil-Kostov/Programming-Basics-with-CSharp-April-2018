using System;

namespace Beep
{
    class Program
    {
        static void Main()
        {
            for (int i = 200; i < 4000; i+=200)
            {
                Console.Beep(i, 100);
            }
        }
    }
}
