using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        private ILookUpDropDownViewModel _viewModel;

        public ILookUpDropDownViewModel ViewModel
        {
            private get => _viewModel;
            set
            {
                var lookUpViewModelChangingEventArgs = new PropertyChangingEventArgs<ILookUpDropDownViewModel>(_viewModel, value);
                LookUpViewModelChanging?.Invoke(this, lookUpViewModelChangingEventArgs);
                if (lookUpViewModelChangingEventArgs.Cancel) return;
                _viewModel = value;
                var lookUpViewModelChangedEventArgs = new LookUpViewModelChangedEventArgs(_viewModel);
                LookUpViewModelChanged?.Invoke(this, lookUpViewModelChangedEventArgs);
            }
        }
    }
}
