using UILookUpDropDownLib.Abstractions.DomainBackendAPI.Services;
using UILookUpDropDownLib.Abstractions.Presenter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.Presenter.Utils;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    public partial class LookUpDataGridViewPresenter<TModel> : ILookUpDataGridViewPresenter<TModel>
    {
        public LookUpDataGridViewPresenter(
            ILookUpDataGridViewModel<TModel> viewModel,
            IGlobalCounterpartyService globalCounterpartyService
            )
        {
            IsDataBinded = false;
            PropertyValidator = new PropertyValidator();
            ViewModel = viewModel;
            GlobalCounterpartyService = globalCounterpartyService;
        }
    }
}
