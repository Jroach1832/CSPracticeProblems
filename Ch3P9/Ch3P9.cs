/*Write an expression that checks for given point {x, y} 
 * if it is within the circle K[{0, 0}, R=5] and out of the 
 * rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle 
 * the lower left and the upper right corners are given.*/

public class Ch3P9
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool inCircle = Math.Pow(x, 2) + Math.Pow(y, 2) <= 25;
        bool outOfRectangle = (x < -1 || x > 5) || (y < 1 || y > 5);

        Console.WriteLine(inCircle && outOfRectangle ? "Yes" : "No");
    }
}