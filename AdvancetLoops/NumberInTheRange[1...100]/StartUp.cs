using System;

namespace NumberInTheRange_1._._._100_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number in the range [1...100]");
            var n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter number in the range [1...100]");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", n);
        }
    }
}
