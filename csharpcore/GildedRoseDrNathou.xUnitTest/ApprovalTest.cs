using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using GildedRoseDrNathou.Core;
using GildedRoseDrNathou.Core.BU;
using Autofac;
using Model.GildedRoseDrNathou.Core;
using System.Collections.Generic;
using System.Linq;
using GildedRoseDrNathou.Core.DAL;

namespace GildedRoseDrNathou.xUnitTest
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var app = new GildedRoseDrNathou.Core.App(new Autofac.ContainerBuilder());
            var fakeData = new List<Item>() { new Item() { Name = "foo", Quality = 0, SellIn = 0 } };

            var daysInTheCurrentMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Day);
            for (var day = 0; day < daysInTheCurrentMonth; day++)
            {
                app.Container.Resolve<IQualityManager>().UpdateQuality(fakeData);
                //Approvals.VerifyAll(fakeoutput.Select(s => s.Name), "");
                Approvals.VerifyAll(fakeData.Select(s => s.Quality), "");
            }
        }
    }
}
