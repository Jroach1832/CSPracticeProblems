/*Write a program that reads from the console 
 * two integer numbers (int) and prints how 
 * many numbers between them exist, such 
 * that the remainder of their division by 
 * 5 is 0. Example: in the range (14, 25) there are
 * 3 such numbers: 15, 20 and 25.*/

using System;

public class Ch4P5
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int lower = (a / 5) * 5;
        int upper = (b / 5) * 5;

        Console.WriteLine("There are {2} Numbers Divisible by " +
            "5 Between {0} and {1}", a, b, (upper - lower) / 5);

    }
}