using System;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewAdapter;

namespace UILookUpDropDownLib.Abstractions.View
{
    public interface ILookUpDropDownView
    {
        ILookUpDropDownViewAdapter LookUpDropDownViewAdapter { get; set; }

        event EventHandler BeforeLookUpDropDownOpened;

        event EventHandler LookUpDropDownClosed;

        event EventHandler LookUpDropDownOpened;

        event EventHandler LookUpUpDownButtonClick;

        event EventHandler SearchTextChanged;

        event EventHandler LookUpLeave;

        event EventHandler LookUpMouseDown;

        event EventHandler LookUpPreviewKeyDown;

        event EventHandler<LookUpDropDownFormClassNameChangedEventArgs> LookUpDropDownFormClassNameChanged;
    }
}
