namespace GildedRoseApp.Entities.ValueObjects
{
    public class ItemQuality
    {
        public int Value { get; set; }
        public ItemQuality(int value) => this.Value = value;

        public void Increase()
        {
            if(this.Value >= 50)
                return;

            ++this.Value;
        }
        public void Increase(int increaseQualityRate)
        {
            for(int i=0; i<increaseQualityRate; i++)
            {
                this.Decrease();
            }
        }
        
        public void Decrease()
        {
            if(this.Value <= 0)
                return;

            --this.Value;
        }
        public void Decrease(int decreaseQualityRate)
        {
            for(int i=0; i<decreaseQualityRate; i++)
            {
                this.Decrease();
            }
        }
    }
}
