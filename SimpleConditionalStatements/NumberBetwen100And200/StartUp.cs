using System;

namespace NumberBetwen100And200
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number > 200)
            {
                Console.WriteLine("Grater than 200");
            }
            else
            {
                Console.WriteLine("Betwin 100 and 200");
            }
        }
    }
}
