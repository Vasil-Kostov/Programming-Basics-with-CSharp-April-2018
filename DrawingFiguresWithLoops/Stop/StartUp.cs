using System;

namespace Stop
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var fgsd = "\\___________//" + "\\_______________________//";
            Console.WriteLine(new string('.', n + 1) + new string('_', n * 2 + 1) + new string('.', n + 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + "//" + new string('_', (n * 2 - 1) + (i * 2)) +
                    @"\\" + new string('.', n - i));
            }

            Console.WriteLine("//" + new string('_', (n * 2 - 3)) + "STOP!" + new string('_', (n * 2 - 3)) + @"\\");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', i) + @"\\" + new string('_', (n * 4 - 1) - (i * 2)) +
                    "//" + new string('.', i));
            }
        }
    }
}
