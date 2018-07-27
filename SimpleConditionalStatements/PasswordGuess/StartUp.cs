using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pass = "s3cr3t!P@ssw0rd";

            if (input == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
