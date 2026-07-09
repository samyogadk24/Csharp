// Declare variables for principal, rate, and time, then calculate simple interest.

using System;
class Question8
{
    
public static void DisplaySI()
    {
        double principle = 40;
        double rate = 30;
        double time = 50;

        double simpleinterst =principle*time*rate/100;

        Console.WriteLine($"The Simple interest is {simpleinterst} ");
    }
}