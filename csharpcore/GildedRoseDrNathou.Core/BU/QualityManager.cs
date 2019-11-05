using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseDrNathou.Core.DAL;
using Model.GildedRoseDrNathou.Core;

namespace GildedRoseDrNathou.Core.BU
{
    public class QualityManager : IQualityManager
    {
        private readonly IItemRepository _itemrepository;

        public QualityManager(IItemRepository itemrepository)
        {
            _itemrepository = itemrepository;
        }

        public void UpdateQuality(IList<Item> itemList)
        {
            for (var i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].Name != "Aged Brie" && itemList[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (itemList[i].Quality > 0)
                    {
                        if (itemList[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            itemList[i].Quality = itemList[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (itemList[i].Quality < 50)
                    {
                        itemList[i].Quality = itemList[i].Quality + 1;

                        if (itemList[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (itemList[i].SellIn < 11)
                            {
                                if (itemList[i].Quality < 50)
                                {
                                    itemList[i].Quality = itemList[i].Quality + 1;
                                }
                            }

                            if (itemList[i].SellIn < 6)
                            {
                                if (itemList[i].Quality < 50)
                                {
                                    itemList[i].Quality = itemList[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (itemList[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    itemList[i].SellIn = itemList[i].SellIn - 1;
                }

                if (itemList[i].SellIn < 0)
                {
                    if (itemList[i].Name != "Aged Brie")
                    {
                        if (itemList[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (itemList[i].Quality > 0)
                            {
                                if (itemList[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    itemList[i].Quality = itemList[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            itemList[i].Quality = itemList[i].Quality - itemList[i].Quality;
                        }
                    }
                    else
                    {
                        if (itemList[i].Quality < 50)
                        {
                            itemList[i].Quality = itemList[i].Quality + 1;
                        }
                    }
                }
            }
        }

        public void UpdateQuality()
        {
            UpdateQuality(_itemrepository.GetAll());
        }
    }
}
