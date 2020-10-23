namespace GildedRoseApp.Entities.ValueObjects
{
    public class ItemSellIn
    {
        private int value;
        public int Value { get => this.value; }

        public ItemSellIn(int value) => this.value = value;

        public void Descrease() => --this.value;

    }
}
