﻿using System;


// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

class MostAppropriateType
{
    static void Main()
    {
        int a = 52130;
        short b = -115;
        long c = 4825932;
        sbyte d = 97;
        int e = -10000;
        Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
    }
}
