/*Write a program that reads an integer number n 
 * from the console. After that reads n numbers 
 * from the console and prints their sum.*/

using System;

public class Ch4P9
{
    static void Main()
    {
        long total = 0;

        Console.Write("How many numbers to collect? ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            bool valid = int.TryParse(Console.ReadLine(), out int number);

            if (valid)
            {
                total += number;
            }
            else
            {
                i--;
            }


        }

        Console.WriteLine(total);
    }
}