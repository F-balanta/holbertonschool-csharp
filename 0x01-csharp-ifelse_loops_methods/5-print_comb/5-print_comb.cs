﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        for (number = 0; number < 100; number++)
        {
            if (number < 99)
                Console.Write("{0:D2}, ", number);
            if (number > 98)
                Console.Write("{0}\n", number);
        }
    }
}