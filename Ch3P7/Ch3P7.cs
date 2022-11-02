/*The gravitational field of the Moon is approximately 17% of that 
 * on the Earth. Write a program that calculates the weight of a man 
 * on the moon by a given weight on the Earth.*/
using System;

public class Ch3P7
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Weight on moon = {weight * 0.17}");
    }
}