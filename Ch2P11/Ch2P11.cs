/*
 
Write a program that prints on the console isosceles triangle which sides 
consist of the copyright character "©".

 */

using System.Text;

public class Ch2P11
{
    static void Main()
    {
        //this is needed to display the copyright symbol correctly
        //Source: https://www.codeproject.com/Questions/1088072/Console-displaying-C-instead-of-copyright-symbol
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("©©©©©©©©©©©");
        Console.WriteLine(" ©       ©");
        Console.WriteLine("  ©     ©");
        Console.WriteLine("   ©   ©");
        Console.WriteLine("     ©");
    }
}