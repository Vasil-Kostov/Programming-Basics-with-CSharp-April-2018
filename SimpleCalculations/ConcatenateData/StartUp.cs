using System;

namespace ConcatenateData
{
    class StartUp
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}."
                ,firstName, secondname, age, town);
        }
    }
}
