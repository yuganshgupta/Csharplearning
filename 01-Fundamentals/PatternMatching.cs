using System;

class PatternMatching
{
    public static void Run()
    {
        object a = 69;
        if(a is int number)
        {
            a = number- 2; 
        }

        object b = 12.2;
        if(b is not string)
        {
            System.Console.WriteLine("B is not  a string");
        }
        
        int Marks = 94;
        if(Marks is >= 85 and <= 99)
        {
            System.Console.WriteLine("GGs");
        }

    }
}