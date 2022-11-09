/*Write a program that calculates the sum (with precision of 0.001) 
 * of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …*/

//Note: I think the actual correct answer is 0.693
//The author says it's 1.307 in the hints.
//WolframAlpha seems to agree with me. 
//See here: https://www.wolframalpha.com/input?i=sum+%28%28-1%29%5En%29*%281+%2F+%28n%2B1%29%29+from+0+to+infinity

using System;

public class Ch4P12
{
    static void Main()
    {
        //initial values
        double total = 0; 
        double denominatorValue = 1;
        double denominatorSign = 1;

        const double tolerance = 0.001; 

        bool terminate = false;

        while (!terminate)
        {
            double term = 1 / (denominatorValue * denominatorSign);
            bool terminatingCondition1 = (denominatorValue - 1) != 0;
            bool terminatingCondition2 = Math.Abs(term - (1 / ((denominatorValue - 1) * (denominatorSign * -1)))) < tolerance;

            if (terminatingCondition1 && terminatingCondition2)
            {
                terminate = true;
            }
            else
            {
                total += term;
                denominatorSign *= -1;
                denominatorValue++;
            }
            
        } 

        Console.WriteLine(Math.Round(total, 3));
    }
}