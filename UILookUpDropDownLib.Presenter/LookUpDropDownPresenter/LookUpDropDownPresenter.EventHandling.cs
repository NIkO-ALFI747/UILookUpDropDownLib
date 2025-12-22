using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        private void OnViewChanging(object sender, PropertyChangingEventArgs<ILookUpDropDownView> e)
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
            View.LookUpDropDownViewAdapter.BindData(ViewModel);
            IsDataBinded = true;
        }

        private void OnLookUpViewModelChanged(object sender, LookUpViewModelChangedEventArgs e)
        {
            if (e.NewViewModel == null) return;
            if (View == null ||
                IsDataBinded) return;
            View.LookUpDropDownViewAdapter.BindData(e.NewViewModel);
            IsDataBinded = true;
        }

        private void OnLookUpViewModelChanging(object sender, PropertyChangingEventArgs<ILookUpDropDownViewModel> e)
        {
            if (e.OldValue == e.NewValue) e.Cancel = true;
        }
    }
}
