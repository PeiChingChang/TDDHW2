using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class NoDiscount : IAmount
    {
        public int CalculateAmount(IEnumerable<book> diffBook)
        {
            return Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 1.0));
        }
    }
}
