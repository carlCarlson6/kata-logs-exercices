using System;
using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp.Entities.Items
{
    public class ConjuredItem : EnrichedItem
    {
        public ConjuredItem(ItemName name, ItemSellIn sellIn, ItemQuality quality) : base(name, sellIn, quality) { }

        public override EnrichedItem Update()
        {
            this.SellIn.Descrease();
            this.Quality.Decrease(2);

            return this;
        }
    }
}
