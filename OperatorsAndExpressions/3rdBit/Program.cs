using System;

namespace _3rdBit
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine((number >> 3) & 1);
        }
    }
}
