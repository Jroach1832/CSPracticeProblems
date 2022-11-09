/*Write a program that prints on the console the first 100 numbers 
 * in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 
 * 89, 144, 233, …*/

using System;

public class Ch4P11
{
    //implemented recursive solution just for fun, but it's really slow
    // it's commented out below for anyone interested
    /*
    static int fibonacci(int n)
    {
        int[] baseCases = new int[] { 0, 1 };
        return baseCases.Contains(n) ? n : fibonacci(n - 1) + fibonacci(n - 2);
    }

    static void Main()
    {
        foreach (var i in Enumerable.Range(0, 10))
        {
            Console.WriteLine(fibonacci(i));
        }
    }
    */

    // Here is the standard solution just using loops
    static void Main()
    {
        double first = 0;
        double second = 1;

        Console.WriteLine(first);

        for (int i = 0; i < 98; i++)
        {
            Console.WriteLine(second);
            double temp = (first + second);
            first = second;
            second = temp;
        }
    }
}