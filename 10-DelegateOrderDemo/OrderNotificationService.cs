using System;
using System.Collections.Generic;
using System.Text;

namespace _10_DelegateOrderDemo;

internal class OrderNotificationService
{
    internal static void ShowConfirmation(string order)
    {
        Console.WriteLine($"{order} was confirmed");
    }
    internal static void SaveOrderLog(string order)
    {
        Console.WriteLine($"{order} was saved");
    }
    internal static void SendNotification(string order)
    {
        Console.WriteLine($"{order} notification sent");
    }


}
