/*Write a program that reads from the console 
 * the radius "r" of a circle and prints its 
 * perimeter and area.*/

public class Ch4P2
{
    static void Main()
    {
        Console.Write("Enter Circle Radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"Circumference: {2.0 * Math.PI * radius}");
        Console.WriteLine($"Area: {Math.PI * Math.Pow(radius, 2)}");


    }
}