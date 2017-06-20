using System.Collections.Generic;

namespace PotterShoppingCart
{
    internal class BookPriceLookupTable
    {
        public static readonly Dictionary<string, int> ISBN_TO_PRICE_TABLE = new Dictionary<string, int>()
        {
            {"9573317249", 100 }, //哈利波特 第一集 繁體中文版
            {"9573317583", 100 }, //哈利波特 第二集 繁體中文版
            {"9573318008", 100 }, //哈利波特 第三集 繁體中文版
            {"9573318318", 100 }, //哈利波特 第四集 繁體中文版
            {"9573319861", 100 }  //哈利波特 第五集 繁體中文版
        };
    }
}