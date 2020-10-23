using System;
using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp.Entities.Items
{
    public class StandardItem : EnrichedItem
    {
        public StandardItem(ItemName name, ItemSellIn sellIn, ItemQuality quality): base(name, sellIn, quality) { }

        public override EnrichedItem Update()
        {
            this.Quality.Decrease();
            this.SellIn.Descrease();
            return this;
        }
    }
}
