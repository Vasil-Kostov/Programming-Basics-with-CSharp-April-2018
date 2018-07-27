using System;

namespace ThirdDigit
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if ((number / 100) > 0)
            {
                number /= 100;
                int remainder = number % 10;
                if (remainder == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", remainder);
                }
            }
            else
            {
                Console.WriteLine("false 0");
            }
        }
    }
}
