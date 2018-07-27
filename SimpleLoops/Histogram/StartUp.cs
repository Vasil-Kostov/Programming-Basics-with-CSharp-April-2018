using System;

namespace Histogram
{
    class StartUp
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            double numbersUnder200 = 0;
            double numbersBetwen200And399 = 0;
            double numbersBetwen400And599 = 0;
            double numbersBetwen600And799 = 0;
            double numbersFrom800AndOver = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    numbersUnder200 += 1;
                }
                else if (number >= 200 && number < 400)
                {
                    numbersBetwen200And399 += 1;
                }
                else if (number >= 400 && number < 600)
                {
                    numbersBetwen400And599 += 1;
                }
                else if (number >= 600 && number < 800)
                {
                    numbersBetwen600And799 += 1;
                }
                else
                {
                    numbersFrom800AndOver += 1;
                }

            }

            Console.WriteLine("{0:F2}%", (numbersUnder200 / n) * 100);
            Console.WriteLine("{0:F2}%", (numbersBetwen200And399 / n) * 100);
            Console.WriteLine("{0:F2}%", (numbersBetwen400And599 / n) * 100);
            Console.WriteLine("{0:F2}%", (numbersBetwen600And799 / n) * 100);
            Console.WriteLine("{0:F2}%", (numbersFrom800AndOver / n) * 100);
        }
    }
}
