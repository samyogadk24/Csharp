//Swap two variables without using a third variable.

using System;
class Question6
{
    public static void SwapVar()
    {
        int a = 15;
        int b = 20;

       Console.WriteLine($" Value Before Swapping A={a} and B={b}");

       a = a + b;
       b = a - b;
       a = a - b;

       Console.WriteLine($" Value After Swapping A={a} and B={b}");



      
        
       ;

    }
}