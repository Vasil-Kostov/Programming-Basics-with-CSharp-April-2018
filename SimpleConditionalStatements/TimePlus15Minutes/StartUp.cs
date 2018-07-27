using System;

namespace TimePlus15Minutes
{
    class StartUp
    {
        static void Main()
        {
            DateTime timeNow = new DateTime();
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            TimeSpan ts = new TimeSpan(hour, minutes + 15, 0);
            timeNow = timeNow.Date + ts;
            if (timeNow.Minute < 10)
            {
                Console.WriteLine("{0:H:mm}", timeNow);
            }
            else
            {
                Console.WriteLine("{0:H:mm}", timeNow);
            }
            
        }
    }
}
