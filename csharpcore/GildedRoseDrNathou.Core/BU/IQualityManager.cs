using System;
using System.Collections.Generic;
using System.Text;
using Model.GildedRoseDrNathou.Core;

namespace GildedRoseDrNathou.Core.BU
{
    public interface IQualityManager
    {
        void UpdateQuality(IList<Item> itemList);
        void UpdateQuality();
    }
}
