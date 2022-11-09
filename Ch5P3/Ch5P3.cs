/*Write a program that finds the biggest 
 * of three integers, using nested if statements.*/

using System;

public class Ch5P5
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        int largest = first;

        if (second > first)
        {
            largest = second;
        }

        if (third > largest)
        {
            largest = third;
        }

        Console.WriteLine("The largest number entered was {0}", largest);
    }
}