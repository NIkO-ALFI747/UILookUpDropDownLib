using UILookUpDropDownLib.Abstractions.Presenter;

namespace UILookUpDropDownLib.Presenter
{
    public partial class LookUpDropDownPresenter
    {
        private void SubscribeInternalEventsToHandlers(ILookUpDropDownPresenter presenter)
        {
            presenter.ViewChanging += OnViewChanging;
            presenter.ViewChanged += OnViewChanged;
            presenter.ViewModelChanged += OnViewModelChanged;
        }
    }
}
