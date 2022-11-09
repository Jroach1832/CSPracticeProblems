/*Write a program that reads an integer number n from the 
 * console and prints all numbers in the range [1…n], each 
 * on a separate line.*/

using System;

public class Ch4P10
{
    static void Main()
    {
        Console.Write("Enter an Integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        foreach (var item in Enumerable.Range(1, n))
        {
            Console.WriteLine(item);
        }
    }
}