using Microsoft.Extensions.DependencyInjection;
using System;
using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Presenter;
using UILookUpDropDownLib.ViewModel;

namespace UILookUpDropDownLib.SharedUtils.DI
{
    public class DIContainer
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public void Configure(ILookUpDropDownView view)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
            var presenter = ServiceProvider.GetRequiredService<ILookUpDropDownPresenter>();
            presenter.View = view;
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILookUpDropDownViewModel, DefaultLookUpDropDownViewModel>();
            services.AddTransient<ILookUpDropDownPresenter, LookUpDropDownPresenter>();
        }
    }
}
