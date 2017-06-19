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
            foreach (var bookItem in books)
            {
                int bookPrice;
                if (BookPriceLookupTable.ISBN_TO_PRICE_TABLE.TryGetValue(bookItem.Key, out bookPrice))
                    totalPrice += bookPrice * bookItem.Value;
            }
            return totalPrice;
        }
    }
}
