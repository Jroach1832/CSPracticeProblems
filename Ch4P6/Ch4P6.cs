/*Write a program that reads two numbers from the console 
 * and prints the greater of them. Solve the problem without 
 * using conditional statements.*/

using System;

public class Ch4P6
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The greater of the two entries is {0}", Math.Max(a, b));
    }
}