using System;

namespace DateAndTime
{
    class Program
    {
        static void Main()
        {
            DateTime time = DateTime.Now;
            string format = "dd/MM/yyyy mm:ss";
            Console.WriteLine(time.ToString(format));
        }
    }
}
