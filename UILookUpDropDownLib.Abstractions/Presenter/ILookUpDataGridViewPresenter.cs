using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;

namespace UILookUpDropDownLib.Abstractions.Presenter
{
    public interface ILookUpDataGridViewPresenter<TModel>
    {
        ILookUpDataGridView View { set; }

        event EventHandler<PropertyChangingEventArgs<ILookUpDataGridView>> ViewChanging;

        event EventHandler ViewChanged;

        event EventHandler<LookUpDataGridViewModelChangedEventArgs<TModel>> LookUpDataGridViewModelChanged;

        event EventHandler<PropertyChangingEventArgs<ILookUpDataGridViewModel<TModel>>> LookUpDataGridViewModelChanging;
    }
}
