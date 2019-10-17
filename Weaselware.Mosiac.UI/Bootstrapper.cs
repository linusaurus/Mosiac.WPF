using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Weaselware.Mosiac.Model;
using  Weaselware.Mosiac.DataAccess;

namespace Weaselware.Mosiac.UI
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<Main>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();

            //builder.RegisterType<DatabaseContext>().AsSelf();
            //builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            //builder.RegisterType<PartDetailView>().AsSelf();
            //builder.RegisterType<PartDetailViewModel>().AsSelf();

            //builder.RegisterType<MainViewModel>().AsSelf();


            //builder.RegisterType<LookupDataService>().AsImplementedInterfaces();

            //builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();
            //builder.RegisterType<AssetService>().As<IAssetService>();
            //builder.RegisterType<PartRepository>().As<IPartRepository>();
            //builder.RegisterType<PartService>().As<IPartService>();

            return builder.Build();
        }
    }
}
