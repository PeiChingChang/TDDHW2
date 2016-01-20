using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class twentyPercentageOf:IAmount
    {
        public int CalculateAmount(IEnumerable<book> diffBook, IEnumerable<book> sameBook)
        {
            return Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 0.8 + sameBook.Sum(o => o.Price)));
        }
    }
}
