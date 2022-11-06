/*Write a program that reads from the console 
 * three numbers of type int and prints their sum.*/

using System;

public class Ch4P1
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum is {a + b + c}");
    }
}