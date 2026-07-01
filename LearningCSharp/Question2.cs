//Create two integer variables and print their sum.

using System;

public class Question2
{
public static void Main()
    {
        Question2.Sum(5,5);
    }

public static void Sum(int a ,int b)
    {
        int c = a + b;

        Console.WriteLine($"Sum of two number {a} and {b} is {c}");
        
    }
}