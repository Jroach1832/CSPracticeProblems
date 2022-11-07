/*Write a program that reads five integer 
 * numbers and prints their sum. If an invalid 
 * number is entered the program should prompt 
 * the user to enter another number.*/

//Neat way of doing input validation found here:
//https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0

using System;

public class Ch4P7
{
    static void Main()
    {
        long total = 0;

        for (int i = 0; i < 5; i++)
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
