using Microsoft.Extensions.DependencyInjection;
using System;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Repositories;
using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Services;
using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.DomainBackendAPI.Repositories;
using UILookUpDropDownLib.DomainBackendAPI.Services;
using UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter;
using UILookUpDropDownLib.Presenter.LookUpDropDownPresenter;
using UILookUpDropDownLib.ViewModel;

namespace UILookUpDropDownLib.DIContainer.DI
{
    public class DIContainer<TModel>
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public void Configure(ILookUpDropDownView view)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
            var lookUpPresenter = ServiceProvider.GetRequiredService<ILookUpDropDownPresenter>();
            lookUpPresenter.View = view;
            var dataGridViewPresenter = 
                ServiceProvider.GetRequiredService<ILookUpDataGridViewPresenter<TModel>>();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILookUpDropDownViewModel, DefaultLookUpDropDownViewModel>();
            services.AddTransient<ILookUpDropDownPresenter, LookUpDropDownPresenter>();
            services.AddTransient<ILookUpDataGridViewModel<TModel>, LookUpDataGridViewModel<TModel>>();
            services.AddTransient<ILookUpDataGridViewPresenter<TModel>, LookUpDataGridViewPresenter<TModel>>();
            services.AddTransient<IGlobalCounterpartyRepository, GlobalCounterpartyRepository>();
            services.AddTransient<IGlobalCounterpartyService, GlobalCounterpartyService>();
        }
    }
}
