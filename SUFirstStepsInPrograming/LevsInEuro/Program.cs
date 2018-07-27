using System;

namespace LevsInEuro
{
    class Program
    {
        static void Main()
        {
            var levs = int.Parse(Console.ReadLine());
            var euro = levs / 1.95583;
            Console.WriteLine(euro);
            
        }
    }
}
