using System;

namespace DevisionWithoutResidue
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            double numsDevidebleOf2 = 0;
            double numsDevidebleOf3 = 0;
            double numsDevidebleOf4 = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    numsDevidebleOf2 += 1;
                }
                if (number % 3 == 0)
                {
                    numsDevidebleOf3 += 1;
                }
                if (number % 4 == 0)
                {
                    numsDevidebleOf4 += 1;
                }
            }

            Console.WriteLine("{0:F2}%", (numsDevidebleOf2 / n) * 100);
            Console.WriteLine("{0:F2}%", (numsDevidebleOf3 / n) * 100);
            Console.WriteLine("{0:F2}%", (numsDevidebleOf4 / n) * 100);
        }
    }
}
