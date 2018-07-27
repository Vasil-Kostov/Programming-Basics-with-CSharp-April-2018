using System;

namespace SmallShop
{
    class StartUp
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(amount * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(amount * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(amount * 1.2);
                        break;
                    case "sweets":
                        Console.WriteLine(amount * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(amount * 1.6);
                        break;
                    default:
                        break;
                }
            }
            else if (town == "plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(amount * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(amount * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(amount * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(amount * 1.3);
                        break;
                    case "peanuts":
                        Console.WriteLine(amount * 1.5);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(amount * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(amount * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(amount * 1.1);
                        break;
                    case "sweets":
                        Console.WriteLine(amount * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(amount * 1.55);
                        break;
                    default:
                        break;
                }
            }
        }
        }
    }

