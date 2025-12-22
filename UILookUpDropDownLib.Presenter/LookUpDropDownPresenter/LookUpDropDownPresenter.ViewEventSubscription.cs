using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        private void SubscribeViewEventsToHandlers(ILookUpDropDownView view)
        {
            view.BeforeLookUpDropDownOpened += OnBeforeLookUpDropDownOpened;
            view.LookUpDropDownClosed += OnLookUpDropDownClosed;
            view.LookUpDropDownOpened += OnLookUpDropDownOpened;
            view.LookUpUpDownButtonClick += OnLookUpUpDownButtonClick;
            view.SearchTextChanged += OnSearchTextChanged;
            view.LookUpLeave += OnLookUpLeave;
            view.LookUpMouseDown += OnLookUpMouseDown;
            view.LookUpPreviewKeyDown += OnLookUpPreviewKeyDown;
            view.LookUpDropDownFormClassNameChanged += OnLookUpDropDownFormClassNameChanged;
        }
    }
}
