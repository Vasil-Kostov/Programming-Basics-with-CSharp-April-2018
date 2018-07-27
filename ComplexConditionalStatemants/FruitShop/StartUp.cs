using System;

namespace FruitShop
{
    class StartUp
    {
        static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", (amount * 2.7));
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", (amount * 1.25));
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", (amount * 0.9));
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", (amount * 1.6));
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", (amount * 3));
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", (amount * 5.6));
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", (amount * 4.2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" 
                || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", (amount * 2.5));
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", (amount * 1.2));
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", (amount * 0.85));
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", (amount * 1.45));
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", (amount * 2.7));
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", (amount * 5.5));
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", (amount * 3.85));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
