﻿using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] new_array;
        int i;

        new_array = new int[size];
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.Write("\n");
            return new_array;
        }
        for (i = 0; i < size; i++)
        {
            new_array[i] = i;
            if (i < size)
                Console.Write(" ");
            Console.Write("{0}", new_array[i]);
        }
        Console.WriteLine("\n");
        return new_array;
    }
}