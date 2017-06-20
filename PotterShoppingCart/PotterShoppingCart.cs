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
            int groupAmount = 0;
            if (books.Count > 1)
                totalPrice += CalculateGroupPrice(books, ref groupAmount);

            books = books.ToDictionary(x => x.Key, x => x.Value - groupAmount);
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

        private static int CalculateGroupPrice(Dictionary<string, int> books, ref int setAmount)
        {
            int totalPrice = 0;
            int oneSetPrice = 0;
            foreach (var bookItem in books)
            {
                int bookPrice;
                if (BookPriceLookupTable.ISBN_TO_PRICE_TABLE.TryGetValue(bookItem.Key, out bookPrice))
                    oneSetPrice += bookPrice;
            }
            setAmount = books.Min(x => x.Value);
            totalPrice += (int) (oneSetPrice * setAmount * 0.95);
            return totalPrice;
        }
    }
}
