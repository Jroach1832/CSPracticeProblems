/*
 
Declare two variables of type string and assign them values "Hello" and "World". 
Declare a variable of type object and assign to it the value obtained of concatenation 
of the two variables of type string (do not miss the space in the middle). 
Declare a third variable of type string and initialize it with the value of 
the variable of type object (you should use type casting).

 */

public class Ch2P8
{
    static void Main()
    {
        String x = "Hello";
        String y = "World";
        object both = x + " " + y;
        String both2 = (String)both;

        Console.WriteLine(both2);
    }
}