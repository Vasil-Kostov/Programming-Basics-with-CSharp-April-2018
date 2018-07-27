using System;

namespace OddVsEvenPosition
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;
            double oddSum = 0;

            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;
            double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    var num = double.Parse(Console.ReadLine());
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    var num = double.Parse(Console.ReadLine());
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }

            Console.WriteLine("OddSum={0}",oddSum);
            Console.WriteLine("OddMin={0}", oddMin != double.MaxValue ? Convert.ToString(oddMin) : "No");
            Console.WriteLine("OddMax={0}", oddMax != double.MinValue ? Convert.ToString(oddMax) : "No");
            Console.WriteLine("EvenSum={0}", evenSum);
            Console.WriteLine("EvenMin={0}", evenMin != double.MaxValue ? Convert.ToString(evenMin) : "No");
            Console.WriteLine("EvenMax={0}", evenMax != double.MinValue ? Convert.ToString(evenMax) : "No");
        }
    }
}
