// Declare two variables of type string with values "Hello" and "World".
// Declare a variable of type object. Assign to this variable the value obtained
// of concatenation of the two string variables (add space if necessary).
// Print the variable of type object

using System;

class Ch2P7
{
    static void Main()
    {
        String x = "Hello";
        String y = "World";
        object helloWorld = x + " " + y;

        Console.WriteLine(helloWorld);
    }
}