using System;

public class Ch3P6
{
    static void Main()
    {
        //Reading width from user input
        Console.Write("Enter the width: "); 
        int width = Convert.ToInt32(value: Console.ReadLine());

        //Reading height from user input
        Console.Write("Enter the height: ");
        int height = Convert.ToInt32(value: Console.ReadLine());

        //Calculations
        int perimeter = 2 * (width + height);
        int area = (width * height);

        //Output
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Area: {area}");
    }
}