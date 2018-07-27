using System;

namespace _5.CatFoodMeow
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n - 1) + '|');
            for (int i = 0; i < n * 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write('/');
                }
            }
            Console.WriteLine('|' + new string('.', n - 1));
            Console.WriteLine(new string('.', n - 1) + '|' + new string('~', n * 2) 
                + '|' + new string('.', n - 1));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - 1) + '|');
                Console.Write(new string(' ', i));
                for (int j = 0; j < n * 2 - i * 2; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('{');
                    }
                    else
                    {
                        Console.Write('}');
                    }
                }
                Console.Write(new string(' ', i));
                Console.WriteLine('|' + new string('.', n - 1));
            }

            Console.WriteLine(new string('.', n - 1) + '|' + new string(' ',n - 2) +
                "MEOW" + new string(' ',n - 2) + '|' + new string('.', n - 1));
            Console.WriteLine(new string('.', n - 1) + '|' + new string(' ',n - 2) +
                "FOOD" + new string(' ', n - 2) + '|' + new string('.', n - 1));

            for (int i = n; i >= 0; i--)
            {
                if (i != n)
                {
                    Console.Write(new string('.', n - 1) + '|');
                    Console.Write(new string(' ', i));
                }
                for (int j = 0; j < n * 2 - i * 2; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('{');
                    }
                    else
                    {
                        Console.Write('}');
                    }
                }
                if (i != n)
                {
                    Console.Write(new string(' ', i));
                    Console.WriteLine('|' + new string('.', n - 1));
                }
                
            }

            Console.WriteLine(new string('.', n - 1) + '|' + new string('~', n * 2)
                + '|' + new string('.', n - 1));
            Console.Write(new string('.', n - 1) + '|');
            for (int i = 0; i < n * 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write('/');
                }
            }
            Console.WriteLine('|' + new string('.', n - 1));
        }
    }
}
