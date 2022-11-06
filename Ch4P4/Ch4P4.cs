/*Write a program that prints three numbers in three 
 * virtual columns on the console. Each column should 
 * have a width of 10 characters and the numbers should
 * be left aligned. The first number should be an integer 
 * in hexadecimal; the second should be fractional positive; 
 * and the third – a negative fraction. The last two numbers 
 * have to be rounded to the second decimal place.*/

using System;

public class Ch4P4
{
    static void Main()
    {
        int a = 123;
        double b = 29.9;
        double c = -42.1;

        Console.WriteLine("|0x{0,-8:X}|", a);
        Console.WriteLine("|{0, -10:F2}|", b);
        Console.WriteLine("|{0,-10:F2}|", c);
    }
}