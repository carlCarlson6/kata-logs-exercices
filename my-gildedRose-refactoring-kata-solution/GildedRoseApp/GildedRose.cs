using System.Linq;
using System.Collections.Generic;
using GildedRoseApp.Entities;
using GildedRoseApp.Entities.Items;

namespace GildedRoseApp
{
    public class GildedRose
    {
        private IList<EnrichedItem> Items;
        public GildedRose(IList<EnrichedItem> items) => this.Items = items;

        public IList<EnrichedItem> UpdateQuality() => this.Items.ToList().Select(item => item.Update()).ToList();
    }
}
