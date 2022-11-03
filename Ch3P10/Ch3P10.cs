/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:

-     Calculates the sum of the digits (in our example 2+0+1+1 = 4).

-     Prints on the console the number in reversed order: dcba (in our example 1102).

-     Puts the last digit in the first position: dabc (in our example 1201).

-     Exchanges the second and the third digits: acbd (in our example 2101).*/

using System;

public class Ch3P10
{
    static void Main()
    {
        //User input
        Console.Write("Enter a 4-digit Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //Calculations
        int first = (number / 1000) % 10;
        int second = (number / 100) % 10;
        int third = (number / 10) % 10;
        int fourth = (number / 1) % 10;
        int total = first + second + third + fourth;
        int reverse = (fourth * 1000) + (third * 100) + (second * 10) + (first);
        int lastInFirst = (fourth * 1000) + (first * 100) + (second * 10) + (third);
        int secondThirdExchanged = (first * 1000) + (third * 100) + (second * 10) + (fourth);

        //Display output
        Console.WriteLine($"Sum of digits = {total}");
        Console.WriteLine($"Number reversed = {reverse}");
        Console.WriteLine($"Number with last digit in first position = {lastInFirst}");
        Console.WriteLine($"Number with second and third digit exchanged = {secondThirdExchanged}");


    }
}