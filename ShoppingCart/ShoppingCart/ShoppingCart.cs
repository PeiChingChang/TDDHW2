using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        public int CalculateAmount(List<book> bookCollection)
        {
            int amount = 0;
            return amount;
        }
    }

    public class book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
