using System;

class Ch1P10
{
    static void Main()
    {
        for (int i = 2; i < 102; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(-1 * i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

