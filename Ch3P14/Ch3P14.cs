/*Write a program that checks if a given number n (1 < n < 100) 
 * is a prime number (i.e. it is divisible without remainder only 
 * to itself and 1).*/

using System;

public class Ch3P14
{
    public static double number;
    public static bool isPrime = true;

    static void Main()
    {

        bool numberInRange = false;

        while (!numberInRange)
        {
            Console.Write("Enter a number between 1 and 100: ");
            number = Convert.ToDouble(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                numberInRange = true;
            }
            else
            {
                Console.WriteLine("Invalid Selection. Try again.");
            }
        }

        int ceil = Convert.ToInt32(Math.Ceiling(Math.Sqrt(number)));

        foreach (var i in Enumerable.Range(2, ceil))
        {

            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? $"{number} is Prime" : $"{number} is Not Prime");


    }

}