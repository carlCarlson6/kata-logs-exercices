using System;
using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp.Entities.Items
{
    public class SulfurasItem : EnrichedItem
    {
        public SulfurasItem(ItemName name, ItemSellIn sellIn, ItemQuality quality) : base(name, sellIn, quality) 
        {
            this.Quality.Value = 80;
        }

        public override EnrichedItem Update()
        {
            this.SellIn.Descrease();
            return this;
        }
    }
}
