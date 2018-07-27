using System;

namespace TheCleverLili
{
    class StartUp
    {
        static void Main()
        {
            var age = int.Parse(Console.ReadLine());
            var priceOfTheMachine = double.Parse(Console.ReadLine());
            var priceOfTheToys = int.Parse(Console.ReadLine());
            var numberOfToys = 0;
            var money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += (i * 5);
                }
                else
                {
                    numberOfToys += 1;
                }
            }

            money += (numberOfToys * priceOfTheToys);
            money -= ((age / 2) * 1);
            if (money < priceOfTheMachine)
            {
                Console.WriteLine("No! {0:F2}", priceOfTheMachine - money);
            }
            else
            {
                Console.WriteLine("Yes! {0:F2}", money - priceOfTheMachine);
            }
        }
    }
}
