using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Abstractions.View
{
    public interface ILookUpDropDownView
    {
        ILookUpDropDownViewModel ViewModel { get; set; }

        event EventHandler BeforeLookUpDropDownOpened;

        event EventHandler LookUpDropDownClosed;

        event EventHandler LookUpDropDownOpened;

        event EventHandler LookUpUpDownButtonClick;

        event EventHandler SearchTextChanged;

        event EventHandler LookUpLeave;

        event EventHandler LookUpMouseDown;

        event EventHandler LookUpPreviewKeyDown;

        event EventHandler<LookUpViewModelChangedEventArgs> LookUpViewModelChanged;

        event EventHandler<PropertyChangingEventArgs<ILookUpDropDownViewModel>> LookUpViewModelChanging;

        void BindData();
    }
}
