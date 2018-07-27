using System;

namespace CureencyConverter
{
    class StartUp
    {
        static void Main()
        {
                var value = double.Parse(Console.ReadLine());
                var enterCurrency = Console.ReadLine();
                var exitCurrency = Console.ReadLine();

                if (enterCurrency == "BGN")
                {
                    switch (exitCurrency)
                    {
                        case "GBP":
                            Console.WriteLine("{0} GBP",Math.Round((value / 2.53405), 2));
                            break;
                        case "EUR":
                            Console.WriteLine("{0} EUR", Math.Round((value / 1.95583), 2));
                            break;
                        case "USD":
                            Console.WriteLine("{0} USD", Math.Round((value / 1.79549), 2));
                            break;
                        default:
                            break;
                    }
                }

                else if (enterCurrency == "GBP")
                {
                    var valueInBGN = value * 2.53405;
                    switch (exitCurrency)
                    {
                        case "BGN":
                            Console.WriteLine("{0} BGN", Math.Round((valueInBGN), 2));
                            break;
                        case "EUR":
                            Console.WriteLine("{0} EUR", Math.Round((valueInBGN / 1.95583), 2));
                            break;
                        case "USD":
                            Console.WriteLine("{0} USD", Math.Round((valueInBGN / 1.79549), 2));
                            break;
                        default:
                            break;
                    }
                }

                else if (enterCurrency == "EUR")
                {
                    var valueInBGN = value * 1.95583;
                    switch (exitCurrency)
                    {
                        case "GBP":
                            Console.WriteLine("{0} GBP", Math.Round((valueInBGN / 2.53405), 2));
                            break;
                        case "BGN":
                            Console.WriteLine("{0} BGN", Math.Round((valueInBGN), 2));
                            break;
                        case "USD":
                            Console.WriteLine("{0} USD", Math.Round((valueInBGN / 1.79549), 2));
                            break;
                        default:
                            break;
                    }
                }

            else if (enterCurrency == "USD")
            {
                {
                    var valueInBGN = value * 1.79549;
                    switch (exitCurrency)
                    {
                        case "GBP":
                            Console.WriteLine("{0} GBP", Math.Round((valueInBGN / 2.53405), 2));
                            break;
                        case "BGN":
                            Console.WriteLine("{0} BGN", Math.Round((valueInBGN), 2));
                            break;
                        case "EUR":
                            Console.WriteLine("{0} EUR", Math.Round((valueInBGN / 1.95583), 2));
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }   
        }
    }
}
