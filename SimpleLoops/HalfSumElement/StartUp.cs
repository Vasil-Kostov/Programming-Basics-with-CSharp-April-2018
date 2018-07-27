using System;

namespace HalfSumElement
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            sum -= maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes, sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum - maxNumber));
            }
        }
    }
}
