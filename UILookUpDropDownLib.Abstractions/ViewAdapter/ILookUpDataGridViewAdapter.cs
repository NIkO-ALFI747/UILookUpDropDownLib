using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Abstractions.ViewAdapter
{
    public interface ILookUpDataGridViewAdapter
    {
        void BindData<TModel>(ILookUpDataGridViewModel<TModel> viewModel);
    }
}
