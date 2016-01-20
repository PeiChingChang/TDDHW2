using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public interface IAmount
    {
        int CalculateAmount(IEnumerable<book> diffBook);
    }
}
