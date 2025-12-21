using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;

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
            if (View.ViewModel != null) return;
            if (ViewModel == null) return;
            View.ViewModel = ViewModel;
        }

        private void OnViewModelChanged(object sender, System.EventArgs e)
        {
            if (ViewModel == null) return;
            if (View == null) return;
            View.ViewModel = ViewModel;
        }
    }
}
