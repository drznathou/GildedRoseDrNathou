using System;
using System.Collections.Generic;
using System.Text;
using Model.GildedRoseDrNathou.Core;

namespace GildedRoseDrNathou.Core.DAL
{
    public interface IItemRepository
    {
        IList<Item> GetAll();
    }
}
