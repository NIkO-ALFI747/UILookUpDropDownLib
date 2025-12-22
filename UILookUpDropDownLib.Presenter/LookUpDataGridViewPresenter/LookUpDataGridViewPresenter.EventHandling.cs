using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Abstractions.ViewModel.EventArgs;
using UILookUpDropDownLib.Presenter.Utils;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        private void OnViewChanging(object sender, PropertyChangingEventArgs<ILookUpDataGridView> e)
        {
            var validationResult = PropertyValidator.Validate(e.NewValue);
            if (validationResult.IsError) e.Cancel = true;
        }

        private void OnViewChanged(object sender, System.EventArgs e)
        {
            if (View == null) return;
            SubscribeViewEventsToHandlers(View);
            if (ViewModel == null ||
                IsDataBinded) return;
            View.LookUpDataGridViewAdapter.BindData(ViewModel);
            IsDataBinded = true;
        }

        private void OnLookUpDataGridViewModelChanged(object sender, LookUpDataGridViewModelChangedEventArgs<TModel> e)
        {
            if (e.NewViewModel == null) return;
            if (View == null ||
                IsDataBinded) return;
            View.LookUpDataGridViewAdapter.BindData(e.NewViewModel);
            IsDataBinded = true;
        }

        private void OnLookUpDataGridViewModelChanging(object sender, PropertyChangingEventArgs<ILookUpDataGridViewModel<TModel>> e)
        {
            if (e.OldValue == e.NewValue) e.Cancel = true;
        }
    }
}
