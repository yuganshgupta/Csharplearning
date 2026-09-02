using System;

class TypeCasting
{
    public static void Run()
    {
       int i = 10; 
       long j = i ;

       double t = 22.22;
       int st = (int)t;

       string s = "123";
       int k = int.Parse(s);


       string tryone = "HOLAWORLD";
       var l = int.TryParse(tryone, out int result);
    
        System.Console.WriteLine(i);
        System.Console.WriteLine(j);
        System.Console.WriteLine(t);
        System.Console.WriteLine(st);
        System.Console.WriteLine(s);
        System.Console.WriteLine(k);
        System.Console.WriteLine(l);
        System.Console.WriteLine(result);
    
    }
}