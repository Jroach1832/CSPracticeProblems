/*Write an expression that checks for a given point {x, y} 
 * if it is within the circle K[{0, 0}, R=5]. Explanation: the 
 * point {0, 0} is the center of the circle and 5 is the radius.*/

using System;

public class Ch3P8
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Math.Pow(x, 2) + Math.Pow(y, 2) <= 25 ? "Yes" : "No"); 
    }
}