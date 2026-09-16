using static _10_DelegateOrderDemo.Delegates;

namespace _10_DelegateOrderDemo;

internal static class DelegateDemo
{
    internal static void Run()
    {
        //Console.WriteLine("Hello, World!");
        DiscountHandler handle = DiscountService.StudentDiscount;
        decimal amt = DiscountService.CalculateFinalPrice(5000m, handle);
        Console.WriteLine(amt);

        handle = DiscountService.FestivalDiscount;
        amt = DiscountService.CalculateFinalPrice(5000m, handle);
        Console.WriteLine(amt);

        handle = DiscountService.NoDiscount;
        amt = DiscountService.CalculateFinalPrice(5000m, handle);
        Console.WriteLine(amt);



        // OrderHandler is nullable because removing methods using -=
        // can eventually leave the delegate with no methods and make it null
        OrderHandler? han = OrderNotificationService.ShowConfirmation;

        // += adds more methods to the delegate invocation list
        // Calling han will run all the methods in the order they were added
        han += OrderNotificationService.SaveOrderLog;
        han += OrderNotificationService.SendNotification;

        // ?.Invoke calls the delegate only if it is not null
        han?.Invoke("Test");

        // -= removes methods from the invocation list
        han -= OrderNotificationService.SaveOrderLog;
        han -= OrderNotificationService.SendNotification;

        han?.Invoke("Test");
    }
}
