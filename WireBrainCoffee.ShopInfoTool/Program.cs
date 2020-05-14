using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WireBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available commands");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();



            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                
                var commandHandler= // command handler can be HelpCommandHandler or CoffeeShopCommandHandler
                string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
                    ? new HelpCommandHandler(coffeeShops) as ICommandHandler
                    : new CoffeeShopCommandHandler(coffeeShops, line);
                
                commandHandler.HandleCommand();
            }
        }
    }
}
