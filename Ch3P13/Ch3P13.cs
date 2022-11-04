
/*We are given the number n, the value v (v = 0 or 1) 
 * and the position p. write a sequence of operations 
 * that changes the value of n, so the bit on the position 
 * p has the value of v. Example: n=35, p=5, v=0 -> n=3.
 * Another example: n=35, p=2, v=1 -> n=39.*/

using System;

public class Ch3P13
{
    static void Main()
    {
        int n = 35; //number
        int p = 2; //position
        int v = 1; //value
        int i = 1;

        int nNew = v == 0 ? ~(i << p) & n : (i << p) | n;

        Console.WriteLine("Input: ");
        Console.WriteLine($"Binary Representation: {Convert.ToString(n, 2)}");
        Console.WriteLine($"Decimal Representation: {n}");

        Console.WriteLine("\n");

        Console.WriteLine("Output:");  
        Console.WriteLine($"Binary Representation: {Convert.ToString(nNew, 2)}");
        Console.WriteLine($"Decimal Representation: {nNew}");

    }
}