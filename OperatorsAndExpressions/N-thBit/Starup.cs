using System;

namespace N_thBit
{
    class Starup
    {
        static void Main()
        {
            uint p = uint.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << n;
            Console.WriteLine((p & mask) >> n);
        }
    }
}
