using static _10_DelegateOrderDemo.Delegates;

namespace _10_DelegateOrderDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Func<decimal, decimal>discalc = amount  => amount - (amount * 0.15m);
        Console.WriteLine(discalc(5000m));

        Action<string> show = orderid => Console.WriteLine($"Order with the id : {orderid} is now confirmed");
        show("ORD101");


    }
}
