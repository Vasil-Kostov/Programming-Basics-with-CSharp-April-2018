using System;

namespace AnimalType
{
    class StartUp
    {
        static void Main()
        {
            var animal = Console.ReadLine().ToLower();

            if (animal == "dog")
                Console.WriteLine("mammal");
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
                Console.WriteLine("reptile");
            else
                Console.WriteLine("unknown");
        }
    }
}
