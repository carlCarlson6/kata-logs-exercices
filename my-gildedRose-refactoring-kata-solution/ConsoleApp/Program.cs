using GildedRoseApp;
using System.Collections.Generic;
using System.Linq;
using System;
using GildedRoseApp.Entities.Items;

namespace GildedRoseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>{
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
				new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
            };
        
            GildedRose app = new GildedRose(items.ToList().Select(item => ItemCreator.Construct(item)).ToList());

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                items.ToList().ForEach(item => Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality));
                Console.WriteLine("");
                items = app.UpdateQuality().ToList().Select(updatedItem => updatedItem.SimpleItem).ToList();
            }
        }

    }
}
