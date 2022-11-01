/*Write an expression that checks for a given integer if its third digit (right to left) is 7.*/
using System;

public class Ch3P3
{
    static void Main()
    {
        //int a = 751702;
        int a = 10750215;
        bool check = (a / 100) % 10 == 7;

        Console.WriteLine(check ? "Third Digit is 7": "Third Digit is not 7");
    }
}