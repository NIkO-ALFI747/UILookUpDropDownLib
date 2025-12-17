using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Presenter
{
    public partial class LookUpDropDownPresenter
    {
        private ILookUpDropDownViewModel _viewModel;

        public ILookUpDropDownViewModel ViewModel
        {
            private get => _viewModel;
            set
            {
                _viewModel = value;
                ViewModelChanged?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
