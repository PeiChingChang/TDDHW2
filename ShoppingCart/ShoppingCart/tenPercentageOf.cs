using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class tenPercentageOf:IAmount
    {
        public int CalculateAmount(IEnumerable<book> diffBook, IEnumerable<book> sameBook)
        {
            return Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 0.9 + sameBook.Sum(o => o.Price)));
        }
    }
}
