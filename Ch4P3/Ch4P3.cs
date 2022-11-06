/*A given company has name, address, phone number, 
 * fax number, web site and manager. 
 * The manager has name, surname and phone number. 
 * Write a program that reads information about the 
 * company and its manager and then prints it on the console.*/

using System;

public class Ch4P3
{
    static void Main()
    {
        Console.Write("Company Name: ");
        String companyName = Console.ReadLine();

        Console.Write("Company Address: ");
        String companyAddress = Console.ReadLine();

        Console.Write("Company Phone: ");
        String companyPhone = Console.ReadLine();

        Console.Write("Company Fax: ");
        String companyFax = Console.ReadLine();

        Console.Write("Company Web Site: ");
        String companyWebSite = Console.ReadLine();

        Console.Write("Manager First Name: ");
        String managerFirstName = Console.ReadLine();

        Console.Write("Manager Surname: ");
        String managerSurname = Console.ReadLine();

        Console.Write("Manager Phone: ");
        String managerPhone = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Company Name: {0}\n" +
                          "Company Addresss: {1}\n" +
                          "Company Phone: {2}\n" +
                          "Company Fax: {3}\n" +
                          "Company Website: {4}\n" +
                          "Manager First Name: {5}\n" +
                          "Manager Surname: {6}\n" +
                          "Manager Phone: {7}",
                          companyName,
                          companyAddress,
                          companyPhone,
                          companyFax,
                          companyWebSite,
                          managerFirstName,
                          managerSurname,
                          managerPhone);
    }
}