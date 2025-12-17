using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Abstractions.View.EventArgs
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
