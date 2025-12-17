using System.Collections.Generic;
using UILookUpDropDownLib.SharedUtils.DI;
using UILookUpDropDownLib.UIKit.LookUpDropDown;
using UILookUpDropDownLib.BackendAPI.DIContainer;
using System.ComponentModel;

namespace UILookUpDropDownLib.DomainUIKit
{
    public class CounterpartyLookUpDropDown : LookUpDropDown
    {
        private DIContainer DIContainer { get; set; }

        public bool IsDesignTime() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public CounterpartyLookUpDropDown()
        {
            if (IsDesignTime()) return;
            BackendAPIBootstrapper.Initialize();
            DIContainer = new DIContainer();
            DIContainer.Configure(this);
            var dbService = BackendAPIAccessor.DbService;
            dbService.CallProcedure("GetData", new Dictionary<string, object>());
        }
    }
}
