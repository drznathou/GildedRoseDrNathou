using System.Collections.Generic;
using Autofac;
using Model.GildedRoseDrNathou.Core;

namespace GildedRoseDrNathou.Core
{
    public class App
    {
        public Autofac.IContainer Container { get; internal set; }
        public App(ContainerBuilder containerBuilder)
        {
            Container = new AppSetup().CreateContainer(containerBuilder ?? new ContainerBuilder());
        }
    }
}
