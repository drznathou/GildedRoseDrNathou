using System;
using System.Collections.Generic;
using Autofac;
using GildedRoseDrNathou.Core.BU;
using GildedRoseDrNathou.Core.DAL;
using Model.GildedRoseDrNathou.Core;

namespace GildedRoseDrNathou.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new GildedRoseDrNathou.Core.App(new Autofac.ContainerBuilder());

            var itemList = app.Container.Resolve<IItemRepository>().GetAll();
            var daysInTheCurrentMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Day);
            for (var day = 0; day < daysInTheCurrentMonth; day++)
            {
                System.Console.WriteLine("-------- day " + day + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                for (var index = 0; index < itemList.Count; index++)
                {
                    System.Console.WriteLine($"{itemList[index].Name}, {itemList[index].SellIn}, {itemList[index].Quality}");
                }
                System.Console.WriteLine("");
                app.Container.Resolve<IQualityManager>().UpdateQuality(itemList);
            }

            System.Console.ReadLine();
        }
        
    }
}
