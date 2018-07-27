using System;

namespace ExcellentResult
{
    class StartUp
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            if (number >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
