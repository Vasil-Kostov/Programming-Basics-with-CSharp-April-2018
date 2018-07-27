using System;

namespace PriceForTransport
{
    class StartUp
    {
        static void Main()
        {
            var nKm = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            if (nKm < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine("{0:F2}", (nKm * 0.79) + 0.70);
                }
                else
                {
                    Console.WriteLine("{0:F2}", (nKm * 0.90) + 0.70);
                }
            }
            else if (nKm >= 100)
            {
                    Console.WriteLine("{0:F2}", nKm * 0.06);
            }
            else
            {
                Console.WriteLine(nKm * 0.09);
            }
        }
    }
}
