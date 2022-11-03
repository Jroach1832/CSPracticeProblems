
/*We are given number n and position p. Write a sequence of operations that prints the value 
 * of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. 
 * Another example: n=35, p=6 -> 0.*/

using System;

public class Ch3P11
{
    static void Main()
    {
        int n = 35;
        int i = 1;

        //Not exactly what we're being asked for, but this makes the concept make more sense to me
        for (int p = 0; p <= 7; p++)
        {
            int mask = i << p;
            int operation = (n & mask);
            int bitAtP = operation != 0 ? 1 : 0;
            Console.WriteLine($"p={p}, mask={mask}, operation={operation}, bit at p={bitAtP}");
        }
    }
}