/*  Write a program that reads five numbers from the 
 *  console and prints the greatest of them*/

using System;

public class Ch4P8
{
    static void Main()
    {
        int maxVal = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter A number: ");

            bool valid = int.TryParse(Console.ReadLine(), out int number);

            if (valid)
            {
                maxVal = i == 0 ? number : Math.Max(maxVal, number);

            }
            else
            {
                i--;
            }
        }

        Console.WriteLine("Maximum value entered was {0}", maxVal);
        
    }
}