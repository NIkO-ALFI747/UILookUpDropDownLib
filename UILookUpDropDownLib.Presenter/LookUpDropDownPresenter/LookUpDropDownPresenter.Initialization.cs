using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Presenter.Utils;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter : ILookUpDropDownPresenter
    {
        public LookUpDropDownPresenter(
            ILookUpDropDownViewModel viewModel //,
            //IGlobalCounterpartyService globalCounterpartyService
            )
        {
            PropertyValidator = new PropertyValidator();
            SubscribeInternalEventsToHandlers(this);
            ViewModel = viewModel;
            //GlobalCounterpartyService = globalCounterpartyService;
        }
    }
}
