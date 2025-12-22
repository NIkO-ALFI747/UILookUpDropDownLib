using UILookUpDropDownLib.Abstractions.Presenter;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        private void SubscribeInternalEventsToHandlers(ILookUpDataGridViewPresenter<TModel> presenter)
        {
            presenter.ViewChanging += OnViewChanging;
            presenter.ViewChanged += OnViewChanged;
            presenter.LookUpDataGridViewModelChanging += OnLookUpDataGridViewModelChanging;
            presenter.LookUpDataGridViewModelChanged += OnLookUpDataGridViewModelChanged;
        }
    }
}
