//Store the length and breadth of a rectangle and calculate the perimeter.

using System;
using System.ComponentModel;

class Question7
{
    public static void DisplayPerimeter()
    {
        int length =20;
        int breadth =30;

        int perimeter =  2*(length+breadth);

        Console.WriteLine($"The perimeter of rectangle is {perimeter}");


    }
}