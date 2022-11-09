/*Write a program that shows the sign (+ or -) of 
 * the product of three real numbers, without calculating 
 * it. Use a sequence of if operators.*/

using System;

public class Ch5P2
{
    static int Negative(int n)
    {
        return n < 0 ? 1 : 0;
    }

    static void Main()
    {
        Console.Write("Enter First Number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        int negatives = Negative(first) + Negative(second) + Negative(third);

        Console.WriteLine(negatives % 2 == 0 ? "Positive" : "Negative");

    }
}