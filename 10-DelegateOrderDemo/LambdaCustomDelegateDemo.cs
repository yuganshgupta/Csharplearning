using static _10_DelegateOrderDemo.Delegates;

namespace _10_DelegateOrderDemo;

internal static class LambdaCustomDelegateDemo
{
    internal static void Run()
    {
        // Block lambda version
        //DiscountHandler handle = amount =>
        //{
        //    amount = amount - (amount * 0.15m);
        //    return amount;
        //};

        // Expression lambda version
        DiscountHandler handle = amount => amount - (amount * 0.15m);

        decimal amt = DiscountService.CalculateFinalPrice(5000m, handle);
        Console.WriteLine(amt);
    }
}