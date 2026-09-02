using System;

class VarObjectDynamic
{
    public static void Run()
    {
        var a = 10;
        // var figures out the variable type during compilation of the program 
        // in this case a becomes int and now it cant be a string
        object b = 20;
        // int is a value type variable so when we store it in object it gets boxed inside 
        // b is treated as object type even though the value stored inside is int
        dynamic c = 30;
        a = a + 5;
        c = c + 5;
        b = (int)b + 5;
    
        System.Console.WriteLine($"The value of the result is {a}");
        System.Console.WriteLine($"The value of the result is {b}");
        System.Console.WriteLine($"The value of the result is {c}");

        // the variable type is dynamic but the value it can hold be int double string
        // with dynamic the operations are delayed and checked at runtime 
        c = "hello";
        System.Console.WriteLine(c+5);


    }
}