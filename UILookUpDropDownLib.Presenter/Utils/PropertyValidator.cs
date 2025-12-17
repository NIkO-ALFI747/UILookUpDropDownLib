using ErrorOr;
using System.ComponentModel;

namespace UILookUpDropDownLib.Presenter.Utils
{
    internal class PropertyValidator
    {
        public bool IsDesignTime() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public ErrorOr<Success> Validate<T>(T type)
        {
            if (
                IsDesignTime() &&
                type != null
                )
                return Error.Validation();
            return Result.Success;
        }
    }
}
