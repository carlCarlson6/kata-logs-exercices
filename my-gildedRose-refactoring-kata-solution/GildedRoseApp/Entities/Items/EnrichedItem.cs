using GildedRoseApp.Entities.ValueObjects;


namespace GildedRoseApp.Entities.Items
{
    public abstract class EnrichedItem
    {
        public ItemName Name {get;}
        public ItemSellIn SellIn {get;}
        public ItemQuality Quality;

        public Item SimpleItem { get => new Item{Name = this.Name.Value, SellIn = this.SellIn.Value, Quality = this.Quality.Value}; }

        public EnrichedItem(ItemName name, ItemSellIn sellIn, ItemQuality quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public abstract EnrichedItem Update();
    }
}
