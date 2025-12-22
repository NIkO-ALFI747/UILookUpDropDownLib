namespace UILookUpDropDownLib.Abstractions.ViewModel.EventArgs
{
    public class LookUpViewModelChangedEventArgs : System.EventArgs
    {
        public ILookUpDropDownViewModel NewViewModel { get; }

        public LookUpViewModelChangedEventArgs(ILookUpDropDownViewModel newViewModel)
        {
            NewViewModel = newViewModel;
        }
    }
}
