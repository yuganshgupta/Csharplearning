using System;
using System.Collections.Generic;
using System.Text;
using static _10_DelegateOrderDemo.Delegates;

namespace _10_DelegateOrderDemo;

internal class DiscountService
{
    internal static decimal NoDiscount(decimal amount)
    {
        return amount;
    }

    internal static decimal StudentDiscount(decimal amount)
    {
        return (amount - (amount * 0.1m)); 
    }

    internal static decimal FestivalDiscount(decimal amount)
    {
        return (amount - (amount * 0.2m));
    }

    internal static decimal CalculateFinalPrice(decimal amount, DiscountHandler handler)
    {

        // handler contains whichever discount method was selected in Program.cs
        // calling handler(amount) runs that method with the given amount
        decimal finalamt = handler(amount);
        return finalamt;
    }
        
    }


