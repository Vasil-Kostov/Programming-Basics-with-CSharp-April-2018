using System;

namespace ModifyBit
{
    class Starup
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte modifyTo = byte.Parse(Console.ReadLine());

            ulong mask = (ulong)1 << position;

            if (modifyTo == 1)
            {
                Console.WriteLine((ulong)(number | mask));
            }
            else
            {
                Console.WriteLine((ulong)number & ~(mask));
            }
        }
    }
}
