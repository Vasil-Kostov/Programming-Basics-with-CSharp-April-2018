using System;

namespace Number0To100
{
    class StartUp
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            string[] numbersUnder20 = new string[] { "zero", "one", "two", "three", "four", "five", "six",
                "seven", "eight","nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteent", "nineteen"};
            string[] higherNumbers = new string[] {"twenty", "thirty", "forty", "fifty", "sixty", "seventy",
                "eighty", "ninety"};

            if (number > 100 | number < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 20)
            {
                Console.WriteLine(numbersUnder20[number]);
            }
            else if (number > 19 & number < 100)
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("{0}", higherNumbers[(number / 10) - 2]);
                }
                else
                {
                    Console.WriteLine("{0}" + " {1}",
                        higherNumbers[(number / 10) - 2], numbersUnder20[number % 10]);
                }
                
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
        }
    }
}
