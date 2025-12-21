using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Presenter
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
            view.LookUpViewModelChanged += OnLookUpViewModelChanged;
            view.LookUpViewModelChanging += OnLookUpViewModelChanging;
            view.LookUpDropDownFormClassNameChanged += OnLookUpDropDownFormClassNameChanged;
        }
    }
}
