/*Write an expression that checks whether the third bit in a given integer is 1 or 0.*/
using System;

public class Ch3P4
{
    static void Main()
    {
        //int a = 25;
        int a = 67;
        bool bit3 = (a & 8) != 0;
        Console.WriteLine(bit3);
    }
}