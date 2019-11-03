using Xunit;
using System.Collections.Generic;

namespace GildedRoseDrNathou.Core
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> itemList = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(itemList);
            app.UpdateQuality();
            Assert.Equal("fixme", itemList[0].Name);
        }
    }
}