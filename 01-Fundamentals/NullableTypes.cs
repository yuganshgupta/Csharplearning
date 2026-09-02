using System;

class NullableTypes
{
    public static void Run()
    {
        int? age = null;
        age = age ?? 20 ;
        
        string? name = null ;
        System.Console.WriteLine(name?.Length);
    
        var lt = name?.Length ?? -1;
        name??= "someone";


        System.Console.WriteLine(age);
        System.Console.WriteLine(name);
        System.Console.WriteLine(lt);
    }
}