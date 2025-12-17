using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Presenter.Utils;

namespace UILookUpDropDownLib.Presenter
{
    public partial class LookUpDropDownPresenter : ILookUpDropDownPresenter
    {
        public LookUpDropDownPresenter(ILookUpDropDownViewModel viewModel)
        {
            PropertyValidator = new PropertyValidator();
            SubscribeInternalEventsToHandlers(this);
            ViewModel = viewModel;
        }
    }
}
