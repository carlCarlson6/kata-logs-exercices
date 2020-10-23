using GildedRoseApp.Entities.Items;
using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp
{
    public class ItemCreator
    {
        public static EnrichedItem Construct(Item simpleItem)
        {
            EnrichedItem item;
            ItemName name = new ItemName(simpleItem.Name); 
            ItemSellIn sellIn = new ItemSellIn(simpleItem.SellIn);
            ItemQuality quality = new ItemQuality(simpleItem.Quality);

            if(name.IsAgedItem())
            {
                item = new AgedItem(name, sellIn, quality);
            }
            else if(name.IsBackstagePassItem())
            {
                item = new BackstagePassesItem(name, sellIn, quality);
            }
            else if(name.IsSulfurasItem())
            {
                item = new SulfurasItem(name, sellIn, quality);
            }
            else
            {
                item = new StandardItem(name, sellIn, quality);
            }
            
            return item;
        }
    }
}
