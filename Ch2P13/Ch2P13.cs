/*
 
Declare two variables of type int. Assign to them values 5 and 10 respectively. 
Exchange (swap) their values and print them

 */

using System.Text;

public class Ch2P13
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swap, a = " + a + " and b = " + b);

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swap, a = " + a + " and b = " + b);


    }
}