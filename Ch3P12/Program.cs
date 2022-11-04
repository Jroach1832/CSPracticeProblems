/*Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.*/
using System;

public class Ch3P12
{
    static void Main()
    {
        int v = 5;
        int p = 1;
        int i = 1;
        int mask = i << p;

        Console.WriteLine((mask & v) != 0);

    }
}