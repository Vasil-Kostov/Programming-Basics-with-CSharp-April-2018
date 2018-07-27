using System;

namespace _6.HappyCatParking
{
    class StartUp
    {
        static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var sumPerDay = 0.0;
            var taxPerHour = 0.0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                       taxPerHour = 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        taxPerHour = 1.25;
                    }
                    else
                    {
                        taxPerHour = 1;
                    }
                    sumPerDay += taxPerHour;
                }
                Console.WriteLine("Day: {0} - {1:F2} leva", i, sumPerDay);
                sum += sumPerDay;
                sumPerDay = 0;
            }
            Console.WriteLine("Total: {0:F2} leva", sum);
        }
    }
}
