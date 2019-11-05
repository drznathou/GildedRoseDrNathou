using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using GildedRoseDrNathou.Core.BU;
using GildedRoseDrNathou.Core.DAL;

namespace GildedRoseDrNathou.Core
{
    class AppSetup
    {
        public Autofac.IContainer CreateContainer(ContainerBuilder containerBuilder)
        {

            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();

        }

        protected virtual void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ItemRepository>().As<IItemRepository>();
            containerBuilder.RegisterType<QualityManager>().As<IQualityManager>();
        }
    }
}
