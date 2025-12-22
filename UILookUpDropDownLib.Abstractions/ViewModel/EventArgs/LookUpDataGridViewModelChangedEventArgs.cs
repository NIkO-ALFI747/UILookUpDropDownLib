namespace UILookUpDropDownLib.Abstractions.ViewModel.EventArgs
{
    public class LookUpDataGridViewModelChangedEventArgs<TModel> : System.EventArgs
    {
        public ILookUpDataGridViewModel<TModel> NewViewModel { get; }

        public LookUpDataGridViewModelChangedEventArgs(ILookUpDataGridViewModel<TModel> newViewModel)
        {
            NewViewModel = newViewModel;
        }
    }
}
