using GildedRoseApp.Entities.ValueObjects;

namespace GildedRoseApp.Entities.Items
{
    public class AgedItem : EnrichedItem
    {
        public AgedItem(ItemName name, ItemSellIn sellIn, ItemQuality quality) : base(name, sellIn, quality) { }

        public override EnrichedItem Update()
        {
            this.SellIn.Descrease();
            this.Quality.Increase();

            return this;
        }
    }
}
