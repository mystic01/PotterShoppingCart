using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        public static int CalculateTotalPrice(Dictionary<string,int> books)
        {
            int totalPrice = 0;
            int groupAmount = books.Count;
            while (groupAmount > 1)
            {
                totalPrice += CalculateGroupPrice(books, ref groupAmount);
                books = books.ToDictionary(x => x.Key, x => x.Value - groupAmount)
                    .Where(x => x.Value > 0)
                    .ToDictionary(x => x.Key, x => x.Value);
            }

            totalPrice += CalculateRemainPrice(books);
            return totalPrice;
        }

        private static int CalculateRemainPrice(Dictionary<string, int> books)
        {
            int totalPrice = 0;
            foreach (var bookItem in books)
            {
                int bookPrice;
                if (BookPriceLookupTable.ISBN_TO_PRICE_TABLE.TryGetValue(bookItem.Key, out bookPrice))
                    totalPrice += bookPrice * bookItem.Value;
            }
            return totalPrice;
        }

        private static int CalculateGroupPrice(Dictionary<string, int> books, ref int groupAmount)
        {
            int totalPrice = 0;
            int oneGroupPrice = 0;
            foreach (var bookItem in books)
            {
                int bookPrice;
                if (BookPriceLookupTable.ISBN_TO_PRICE_TABLE.TryGetValue(bookItem.Key, out bookPrice))
                    oneGroupPrice += bookPrice;
            }
            groupAmount = books.Min(x => x.Value);

            var discount = GetDiscountByGroupSize(books.Count);
            totalPrice += (int) (oneGroupPrice * groupAmount * discount);
            return totalPrice;
        }

        private static double GetDiscountByGroupSize(int groupSize)
        {
            var discount = 1.0;
            switch (groupSize)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
                case 5:
                    discount = 0.75;
                    break;
            }
            return discount;
        }
    }
}
