using System;
using UILookUpDropDownLib.Abstractions.View.EventArgs;

namespace UILookUpDropDownLib.UIKit.LookUpDropDown
{
    public partial class LookUpDropDown
    {
        public event EventHandler BeforeLookUpDropDownOpened;

        public event EventHandler LookUpDropDownClosed;

        public event EventHandler LookUpDropDownOpened;

        public event EventHandler LookUpUpDownButtonClick;

        public event EventHandler SearchTextChanged;

        public event EventHandler LookUpLeave;

        public event EventHandler LookUpMouseDown;

        public event EventHandler LookUpPreviewKeyDown;

        public event EventHandler<LookUpDropDownFormClassNameChangedEventArgs> LookUpDropDownFormClassNameChanged;
    }
}
