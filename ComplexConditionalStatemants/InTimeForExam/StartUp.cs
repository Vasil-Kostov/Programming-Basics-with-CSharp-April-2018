using System;

namespace InTimeForExam
{
    class StartUp
    {
        static void Main()
        {
            var hourOfTheExam = int.Parse(Console.ReadLine());
            var minuteOfTheExam = int.Parse(Console.ReadLine());
            var hourOfAriving = int.Parse(Console.ReadLine());
            var minuteOfAriving = int.Parse(Console.ReadLine());

            var timeOfExamInMinutes = (hourOfTheExam * 60) + minuteOfTheExam;
            var timeOfArivingInMinutes = (hourOfAriving * 60) + minuteOfAriving;

            //Late
            if (timeOfArivingInMinutes > timeOfExamInMinutes)
            {
                Console.WriteLine("Late");
                if ((timeOfArivingInMinutes - timeOfExamInMinutes) < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeOfArivingInMinutes - timeOfExamInMinutes);
                }
                else if (timeOfArivingInMinutes - timeOfExamInMinutes > 60)
                {
                    int hours = 0;
                    int minutes = timeOfArivingInMinutes - timeOfExamInMinutes;
                    hours = minutes / 60;
                    minutes -= hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                    }
                }
                else //Exactly 1 hour Late
                {
                    Console.WriteLine("1:00 hours after the start");
                }

            }
            //Early
            else if ((timeOfExamInMinutes - timeOfArivingInMinutes) > 30)
            {
                Console.WriteLine("Early");
                if ((timeOfExamInMinutes - timeOfArivingInMinutes) < 60)
                {
                        Console.WriteLine("{0} minutes before the start", timeOfExamInMinutes - timeOfArivingInMinutes);
                }
                else if (timeOfExamInMinutes - timeOfArivingInMinutes > 60)
                {
                    int hours = 0;
                    int minutes = timeOfExamInMinutes - timeOfArivingInMinutes;
                    hours = minutes / 60;
                    minutes -= hours * 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
                    }
                }
                else //Exactly 1 hour Early
                {
                    Console.WriteLine("1:00 hours before the start");
                }
            }
            //30 min or less befor (On Time)
            else if (((timeOfExamInMinutes - timeOfArivingInMinutes) <= 30) && ((timeOfExamInMinutes - timeOfArivingInMinutes) > 0))
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeOfExamInMinutes - timeOfArivingInMinutes);
            }
            //Exactly On Time
            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}
