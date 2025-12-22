using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;

namespace UILookUpDropDownLib.Abstractions.Presenter
{
    public interface ILookUpDropDownPresenter
    {
        ILookUpDropDownView View { set; }

        event EventHandler<PropertyChangingEventArgs<ILookUpDropDownView>> ViewChanging;

        event EventHandler ViewChanged;

        event EventHandler<LookUpViewModelChangedEventArgs> LookUpViewModelChanged;

        event EventHandler<PropertyChangingEventArgs<ILookUpDropDownViewModel>> LookUpViewModelChanging;
    }
}
