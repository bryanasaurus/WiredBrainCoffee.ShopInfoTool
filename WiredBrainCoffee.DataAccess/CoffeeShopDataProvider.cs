using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107, PaperCups = 350 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23, PaperCups = 200 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56, PaperCups = 12 };
        }
    }
}
