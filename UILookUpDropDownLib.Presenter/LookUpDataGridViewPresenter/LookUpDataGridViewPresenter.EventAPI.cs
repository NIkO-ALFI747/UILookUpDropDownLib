using System;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        public event EventHandler<PropertyChangingEventArgs<ILookUpDataGridView>> ViewChanging;

        public event EventHandler ViewChanged;

        public event EventHandler<LookUpDataGridViewModelChangedEventArgs<TModel>> LookUpDataGridViewModelChanged;

        public event EventHandler<PropertyChangingEventArgs<ILookUpDataGridViewModel<TModel>>> LookUpDataGridViewModelChanging;
    }
}
