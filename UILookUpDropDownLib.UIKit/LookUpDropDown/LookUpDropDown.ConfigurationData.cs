using UILookUpDropDownLib.Abstractions.View.EventArgs;

namespace UILookUpDropDownLib.UIKit.LookUpDropDown
{
    public partial class LookUpDropDown
    {
        private string _lookUpDropDownFormClassName;
        public string LookUpDropDownFormClassName
        {
            get => _lookUpDropDownFormClassName;
            set
            {
                _lookUpDropDownFormClassName = value;
                var lookUpDropDownFormClassNameChangedEventArgs = new LookUpDropDownFormClassNameChangedEventArgs(_lookUpDropDownFormClassName);
                LookUpDropDownFormClassNameChanged?.Invoke(this, lookUpDropDownFormClassNameChangedEventArgs);
            }
        }
    }
}
