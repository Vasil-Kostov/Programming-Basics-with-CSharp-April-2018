using System;

namespace GreatestCommonDivisorGCD
{
    class StartUp
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var GCD = 1;
            var tmp = 0;

            while (b > 0)
            {
                tmp = b;
                b = a % b;
                a = tmp;
            }

            GCD = a;
            Console.WriteLine(GCD);
        }
    }
}
