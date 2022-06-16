﻿using System;

namespace IntroToCSharp
{
    class HelloCSharp
    {
        static void Main()
        {
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);
        }
    }
}