using System;
using System.Collections.Generic;
using System.Text;

namespace _10_DelegateOrderDemo
{
    internal class Delegates
    {
        internal delegate decimal DiscountHandler(decimal discount);
        internal delegate void OrderHandler(string order);
    }
}
