using System;

namespace _3.CatTrainingAttendance
{
    class StartUp
    {
        static void Main()
        {
            var hourOfExersise = int.Parse(Console.ReadLine());
            var hourOfAriving = int.Parse(Console.ReadLine());
            var minuteOfAriving = int.Parse(Console.ReadLine());
            var dayOfTheWeek = Console.ReadLine().ToLower();
            var bonusPoints = 0.0;

            if (hourOfAriving == hourOfExersise - 1)
            {
                bonusPoints += 1.5;
            }
            else if (hourOfAriving == hourOfExersise && minuteOfAriving <= 30)
            {
                bonusPoints += 1;
            }
            else
            {
                bonusPoints += 0.5;
            }

            if (dayOfTheWeek == "monday" || dayOfTheWeek == "wednesday" || dayOfTheWeek == "friday")
            {
                bonusPoints += 0.6;
            }
            else if(dayOfTheWeek == "sunday")
            {
                bonusPoints += 2;
            }
            else
            {
                bonusPoints += 0.8;
            }

            Console.WriteLine("{0:F2}", bonusPoints);
        }
    }
}
