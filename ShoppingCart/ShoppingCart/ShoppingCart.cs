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

            if (bookCollection == null || bookCollection.Count() == 0)
                return 0;

            var diffBook = bookCollection.Distinct(o => o.Id);
            var sameBook = bookCollection.Except(diffBook);

            IAmount amount = GetAmount(diffBook.Count());
            if (amount == null)
                return 0;

            return amount.CalculateAmount(diffBook, sameBook);
        }

        private IAmount GetAmount(int diffBookCount)
        {
            IAmount amount = null;
            switch (diffBookCount)
            {
                case 1:
                    return new NoDiscount();
                case 2:
                    return new fivePercentageOf();
                case 3:
                    return new tenPercentageOf();
                case 4:
                    return new twentyPercentageOf();
                case 5:
                    return new twentyFivePercentageOf();
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
