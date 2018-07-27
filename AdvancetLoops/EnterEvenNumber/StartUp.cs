using System;

namespace EnterEvenNumber
{
    class StartUp
    {
        static void Main()
        {
            int n = 0;

            while (true)
            {
                Console.Write("Enter even number: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
                
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
