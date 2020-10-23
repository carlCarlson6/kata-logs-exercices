using System;
using GildedRoseApp.Entities.Items;
using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp.Entities.Items
{
    public class BackstagePassesItem : EnrichedItem
    {
        public BackstagePassesItem(ItemName name, ItemSellIn sellIn, ItemQuality quality) : base(name, sellIn, quality) { }

        public override EnrichedItem Update()
        {
            this.SellIn.Descrease();
            this.UpdateQuality();
            return this;
        }

        private void UpdateQuality()
        {
            if(5 < this.SellIn.Value && this.SellIn.Value <= 10)
            {
                this.Quality.Increase(2);
            }
            else if(this.SellIn.Value <= 5)
            {
                this.Quality.Increase(3);
            }
            else if(this.SellIn.Value <= 0)
            {
                this.Quality.Value = 0;
            }
            else
            {
                this.Quality.Increase();
            }
        }
    }
}
