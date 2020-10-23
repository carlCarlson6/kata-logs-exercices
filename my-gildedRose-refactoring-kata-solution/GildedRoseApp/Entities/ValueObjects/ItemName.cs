using System;

namespace GildedRoseApp.Entities.ValueObjects
{
    public class ItemName
    {
        private String value;
        public String Value { get => this.value; }

        public ItemName(String value) => this.value = value;

        public Boolean IsAgedItem() => this.value.ToLower().Contains("aged");
        public Boolean IsSulfurasItem() => this.value.ToLower().Contains("sulfuras");
        public Boolean IsBackstagePassItem() => this.value.ToLower().Contains("backstage passes");
    
    }

}
