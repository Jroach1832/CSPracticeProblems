//Declare a variable of type char and assign as a value the character,
//which has Unicode code, 72 (use the Windows calculator in order to
//find hexadecimal representation of 72).

class Ch2P5
{
    static void Main()
    {
        //hex representation of 72 is 0x48
        char character = '\u0048';

        Console.WriteLine(character);
    }
}