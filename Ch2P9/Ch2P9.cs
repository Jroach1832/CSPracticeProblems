/*
 
Declare two variables of type string and assign them a 
value “The "use" of quotations causes difficulties.” 
(without the outer quotes). In one of the variables 
use quoted string and in the other do not use it.

 */

public class Ch2P9
{
    static void Main()
    {
        String x = @"The ""use"" of quotations causes difficulties.";
        String y = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}