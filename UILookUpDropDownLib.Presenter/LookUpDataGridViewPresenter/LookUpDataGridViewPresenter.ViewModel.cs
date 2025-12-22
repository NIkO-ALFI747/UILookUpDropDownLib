using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        private ILookUpDataGridViewModel<TModel> _viewModel;

        public ILookUpDataGridViewModel<TModel> ViewModel
        {
            private get => _viewModel;
            set
            {
                var lookUpDataGridViewModelChangingEventArgs = 
                    new PropertyChangingEventArgs<ILookUpDataGridViewModel<TModel>>(_viewModel, value);
                LookUpDataGridViewModelChanging?.Invoke(this, lookUpDataGridViewModelChangingEventArgs);
                if (lookUpDataGridViewModelChangingEventArgs.Cancel) return;
                _viewModel = value;
                var lookUpDataGridViewModelChangedEventArgs = 
                    new LookUpDataGridViewModelChangedEventArgs<TModel>(_viewModel);
                LookUpDataGridViewModelChanged?.Invoke(this, lookUpDataGridViewModelChangedEventArgs);
            }
        }
    }
}
