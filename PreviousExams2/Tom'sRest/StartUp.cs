using System;

namespace Tom_sRest
{
    class StartUp
    {
        static void Main()
        {
            var daysOff = int.Parse(Console.ReadLine());

            var daysInYear = 365;
            daysInYear -= daysOff;

            var playTime = (daysOff * 127) + (daysInYear * 63);
            var diference = Math.Abs(playTime - 30000);
            var hours = 0;
            var minutes = diference;

            for (; minutes >= 60 ; minutes -= 60)
            {
                hours += 1;
            }

            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
