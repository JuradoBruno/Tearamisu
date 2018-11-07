﻿using System;
using Autofac;
//using Tearamisu.Mobile.Contracts.Repository;
//using Tearamisu.Mobile.Contracts.Services.Data;
//using Tearamisu.Mobile.Contracts.Services.General;
using Tearamisu.Mobile.Repository;
//using Tearamisu.Mobile.Services.Data;
//using Tearamisu.Mobile.Services.General;
//using Tearamisu.Mobile.ViewModels;

namespace BethanysPieShop.Mobile.Core.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            ////ViewModels
            //builder.RegisterType<CheckoutViewModel>();
            //builder.RegisterType<ContactViewModel>();
            //builder.RegisterType<LoginViewModel>();
            //builder.RegisterType<MainViewModel>();
            //builder.RegisterType<PieCatalogViewModel>();
            //builder.RegisterType<PieDetailViewModel>();
            //builder.RegisterType<RegistrationViewModel>();
            //builder.RegisterType<ShoppingCartViewModel>().SingleInstance();
            //builder.RegisterType<MenuViewModel>();
            //builder.RegisterType<HomeViewModel>();

            ////services - data
            //builder.RegisterType<CatalogDataService>().As<ICatalogDataService>();
            //builder.RegisterType<ShoppingCartDataService>().As<IShoppingCartDataService>();
            //builder.RegisterType<ContactDataService>().As<IContactDataService>();
            //builder.RegisterType<OrderDataService>().As<IOrderDataService>();

            ////services - general
            //builder.RegisterType<ConnectionService>().As<IConnectionService>();
            //builder.RegisterType<NavigationService>().As<INavigationService>();
            //builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            //builder.RegisterType<DialogService>().As<IDialogService>();
            //builder.RegisterType<PhoneService>().As<IPhoneService>();
            //builder.RegisterType<SettingsService>().As<ISettingsService>().SingleInstance();

            ////General
            //builder.RegisterType<GenericRepository>().As<IGenericRepository>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
