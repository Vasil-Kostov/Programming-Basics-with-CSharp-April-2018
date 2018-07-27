using System;

namespace EqualWords
{
    class StartUp
    {
        static void Main()
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();
            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
