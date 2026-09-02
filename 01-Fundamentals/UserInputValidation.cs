using System;

namespace _01_Fundamentals;

class UserInputValidation
{
    public static void Run()
    {
        System.Console.WriteLine("Enter your name");
        string? name = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(name))
        {
            System.Console.WriteLine("INVALID NAME");
            return; 
        }

        System.Console.WriteLine("Enter ur age here");
        var agecheck = int.TryParse(Console.ReadLine(),out int age);
        if(!agecheck)
        {
            System.Console.WriteLine("Invalid age");
            return;
        }

        System.Console.WriteLine("Enter the marks u got ( In between the range of 0 and 100)");
        var markscheck = int.TryParse(Console.ReadLine(),out int marks);
        if(!markscheck)
        {
            System.Console.WriteLine("Enter a valid number please");
            return;
        }
        
        if (marks is < 0 or > 100)
        {
            System.Console.WriteLine("enter number between 0 and 100 please");
            return;
        }

        System.Console.WriteLine($"The Name is : {name} \n Age is : {age} and \n the marks are : {marks}");
    }
}