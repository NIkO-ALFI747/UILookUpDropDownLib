using System.Collections.Generic;
using UILookUpDropDownLib.UIKit.LookUpDropDown;
using UILookUpDropDownLib.BackendAPI.DIContainer;
using System.ComponentModel;
using UILookUpDropDownLib.Abstractions.DomainUIModels;

namespace UILookUpDropDownLib.DomainUIKit
{
    public class CounterpartyLookUpDropDown : DefaultLookUpDropDown
    {
        private DIContainer.DI.DIContainer<GlobalCounterpartyLookUp> DIContainer { get; set; }

        public bool IsDesignTime() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
            DesignMode;

        public CounterpartyLookUpDropDown()
        {
            if (IsDesignTime()) return;
            BackendAPIBootstrapper.Initialize();
            DIContainer = new DIContainer.DI.DIContainer<GlobalCounterpartyLookUp>();
            DIContainer.Configure(this);
            var dbService = BackendAPIAccessor.DbService;
            dbService.CallProcedure("GetData", new Dictionary<string, object>());
        }
    }
}
