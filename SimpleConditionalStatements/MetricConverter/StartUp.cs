using System;

namespace MetricConverter
{
    class StartUp
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            double valueInMeters = 0;

            switch (input)
            {
                case "m":
                    valueInMeters = number;
                    break;
                case "mm":
                    valueInMeters = number / 1000;
                    break;
                case "cm":
                    valueInMeters = number / 100;
                    break;
                case "mi":
                    valueInMeters = number / 0.000621371192;
                    break;
                case "in":
                    valueInMeters = number / 39.3700787;
                    break;
                case "km":
                    valueInMeters = number / 0.001;
                    break;
                case "ft":
                    valueInMeters = number / 3.2808399;
                    break;
                case "yd":
                    valueInMeters = number / 1.0936133;
                    break;
                default:
                    break;
            }
            switch (output)
            {
                case "m":
                    Console.WriteLine("{0:F8}", valueInMeters);
                    break;
                case "mm":
                    Console.WriteLine("{0:F8}", valueInMeters * 1000);
                    break;
                case "cm":
                    Console.WriteLine("{0:F8}", valueInMeters * 100);
                    break;
                case "mi":
                    Console.WriteLine("{0:F8}", valueInMeters * 0.000621371192);
                    break;
                case "in":
                    Console.WriteLine("{0:F8}", valueInMeters * 39.3700787);
                    break;
                case "km":
                    Console.WriteLine("{0:F8}", valueInMeters * 0.001);
                    break;
                case "ft":
                    Console.WriteLine("{0:F8}", valueInMeters * 3.2808399);
                    break;
                case "yd":
                    Console.WriteLine("{0:F8}", valueInMeters * 1.0936133);
                    break;
                default:
                    break;
            }
        }
    }
}
