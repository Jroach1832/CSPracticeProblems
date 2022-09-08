/*
 
A company dealing with marketing wants to keep a data record of its employees. 
Each record should have the following characteristic – first name, last name, age, 
gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
Declare appropriate variables needed to maintain the information for an 
employee by using the appropriate data types and attribute names.

 */

using System;
using System.Text;

public class Ch2P12
{
    static void Main()
    {
        String FirstName = "Jon";
        String LastName = "Smith";
        char Gender = 'm';
        uint EmployeeNumber = 27560000;

        Console.WriteLine("First Name: " + FirstName);
        Console.WriteLine("Last Name: " + LastName);
        Console.WriteLine("Gender: " + Gender);
        Console.WriteLine("Employee Number: " + EmployeeNumber);
    }
}