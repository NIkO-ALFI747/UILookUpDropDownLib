using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        public event EventHandler<PropertyChangingEventArgs<ILookUpDropDownView>> ViewChanging;

        public event EventHandler ViewChanged;

        public event EventHandler<LookUpViewModelChangedEventArgs> LookUpViewModelChanged;

        public event EventHandler<PropertyChangingEventArgs<ILookUpDropDownViewModel>> LookUpViewModelChanging;
    }
}
