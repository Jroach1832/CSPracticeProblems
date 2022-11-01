/*Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.*/
using System;

public class Ch3P2
{
    static void Main()
    {
        //int a = 10;
        int a = 35;
        bool divBy5And7 = (a % 5 == 0) && (a % 7 == 0);

        Console.WriteLine(divBy5And7 ? "Divisible by Both 5 and 7" : "Not Divisible by Both 5 and 7");
    }
}