using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        public event EventHandler<PropertyChangingEventArgs<ILookUpDropDownView>> ViewChanging;

        public event EventHandler ViewChanged;

        public event EventHandler ViewModelChanged;
    }
}
