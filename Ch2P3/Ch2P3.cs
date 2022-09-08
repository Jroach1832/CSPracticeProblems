//Write a program, which compares correctly two real numbers with accuracy at least 0.000001.

class Ch2P3
{
    static void Main()
    {
        //Setting our tolerance for error
        double tolerance = 0.0000000000001;

        //These are "equal"
        double x = 0.123456789987;
        double y = 0.123456789985;

        //These aren't
        //double x = 0.12345;
        //double y = 0.12344;

        Console.WriteLine(Math.Abs(x - y) <= tolerance);

    }
}