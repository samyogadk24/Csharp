// Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.

 using System;

 class Question3
{
    
    public static void DisplayMarks()
    {
        int physics = 50;
        int chemistry = 45;
        int mathematics = 65;

        int total =physics+chemistry+mathematics;

        Console.WriteLine($"The total marks of three subject is {total}");
    }
}
