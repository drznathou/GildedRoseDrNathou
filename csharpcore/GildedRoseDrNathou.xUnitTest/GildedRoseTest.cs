using Xunit;
using Autofac;
using System.Collections.Generic;
using Model.GildedRoseDrNathou.Core;
using GildedRoseDrNathou.Core.BU;

namespace GildedRoseDrNathou.Core
{
    public class GildedRoseTest
    {
        [Fact]
        public void FixMe()
        {
            IList<Item> itemList = new List<Item> { new Item { Name = "fixme", SellIn = 0, Quality = 0 } };
            var app = new App(new Autofac.ContainerBuilder());
            app.Container.Resolve<IQualityManager>().UpdateQuality(itemList);
            Assert.Equal("fixme", itemList[0].Name);
        }
    }
}