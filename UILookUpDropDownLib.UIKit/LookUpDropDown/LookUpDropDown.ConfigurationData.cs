using C1.Win.C1Input;
using System.ComponentModel;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.SharedUtils.TypeConverters;

namespace UILookUpDropDownLib.UIKit.LookUpDropDown
{
    public partial class LookUpDropDown
    {
        private string _lookUpDropDownFormClassName;

        [TypeConverter(typeof(ClassTypeToStringTypeConverter<DropDownForm>))]
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
