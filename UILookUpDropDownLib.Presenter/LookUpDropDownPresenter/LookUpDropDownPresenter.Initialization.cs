using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Presenter.Utils;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter : ILookUpDropDownPresenter
    {
        public LookUpDropDownPresenter(
            ILookUpDropDownViewModel viewModel
            )
        {
            IsDataBinded = false;
            PropertyValidator = new PropertyValidator();
            SubscribeInternalEventsToHandlers(this);
            ViewModel = viewModel;
        }
    }
}
