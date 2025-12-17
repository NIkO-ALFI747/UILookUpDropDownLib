using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Abstractions.Presenter
{
    public interface ILookUpDropDownPresenter
    {
        ILookUpDropDownView View { set; }

        event EventHandler<PropertyChangingEventArgs<ILookUpDropDownView>> ViewChanging;

        event EventHandler ViewChanged;

        event EventHandler ViewModelChanged;
    }
}
