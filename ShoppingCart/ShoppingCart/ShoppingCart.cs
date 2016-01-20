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

            if (bookCollection == null || bookCollection.Count() == 0)
                return amount;

            var diffBook = bookCollection.Distinct(o => o.Id);
            var sameBook = bookCollection.Except(diffBook);

            switch (diffBook.Count())
            {
                case 1:
                    amount = Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 1.0 + sameBook.Sum(o => o.Price)));
                    break;
                case 2:
                    amount = Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 0.95 + sameBook.Sum(o => o.Price)));
                    break;
                case 3:
                    amount = Convert.ToInt32(Math.Ceiling(diffBook.Sum(o => o.Price) * 0.9 + sameBook.Sum(o => o.Price)));
                    break;
            }

            return amount;
        }
    }

    public class book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }

    public static class EnumerableExtender
    {
        public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                var elementValue = keySelector(element);
                if (seenKeys.Add(elementValue))
                {
                    yield return element;
                }
            }
        }
    }
}
