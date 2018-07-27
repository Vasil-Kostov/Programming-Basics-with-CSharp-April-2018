using System;

namespace OddAndEvenSum
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
