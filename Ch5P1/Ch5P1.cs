/*Write an if-statement that takes two integer variables 
 * and exchanges their values if the first one is greater 
 * than the second one.*/

using System;

public class Ch5P1
{
    static void Main()
    {
        Console.Write("Enter first value: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second value: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First Value = {0}, Second Value = {1}", first, second);
        if (first > second)
        {
            int temp = second;
            second = first;
            first = temp;
            Console.WriteLine("Values Switched!");
            Console.WriteLine("Now First Value = {0}, Second Value = {1}", first, second);
        }
        else
        {
            Console.WriteLine("No need to switch values. They are still the same as above.");
        }
    }
}