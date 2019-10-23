using Autofac;
using System;
using Prism.Events;
using System.Collections.Generic;
using System.Text;
using Weaselware.Mosiac.UI;
using Weaselware.Mosiac.UI.ViewModel;
using Weaselware.Mosiac.Model;
using Weaselware.Mosiac.UI.Services;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.UI.Views;
using MosiacUI.Views.Services;

namespace Weaselware.Mosiac.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<Main>().AsSelf();

            builder.RegisterType<MosiacContext>().AsSelf();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<PartDetailView>().AsSelf();
            builder.RegisterType<PartDetailViewModel>().As<IPartDetailViewModel>();

            


            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();

            builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();
            builder.RegisterType<AssetService>().As<IAssetService>();
            builder.RegisterType<PartRepository>().As<IPartRepository>();
            builder.RegisterType<PartService>().As<IPartService>();

            return builder.Build();
        }
    }
}
