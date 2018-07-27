using System;

namespace PrimeCheck
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isProme = true;
            if (number <= 1)
            {
                isProme = false;
            }
            else
            {
                for (int i = 2; i < number + 1; i++)
                {
                    if (number % i == 0 && number != i)
                    {
                        isProme = false;
                        break;
                    }
                }
            }
            if (isProme)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
           
        }
    }
}
