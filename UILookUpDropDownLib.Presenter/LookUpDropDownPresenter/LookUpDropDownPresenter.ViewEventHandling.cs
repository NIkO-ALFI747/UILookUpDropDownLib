using System.Diagnostics;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        private void OnBeforeLookUpDropDownOpened(object sender, System.EventArgs e)
        {
            
        }

        private void OnLookUpDropDownClosed(object sender, System.EventArgs e)
        {

        }

        private void OnLookUpDropDownOpened(object sender, System.EventArgs e)
        {

        }

        private void OnLookUpUpDownButtonClick(object sender, System.EventArgs e)
        {

        }

        private void OnSearchTextChanged(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"View SearchText changed");
        }

        private void OnLookUpLeave(object sender, System.EventArgs e)
        {

        }

        private void OnLookUpMouseDown(object sender, System.EventArgs e)
        {

        }

        private void OnLookUpPreviewKeyDown(object sender, System.EventArgs e)
        {

        }

        private void OnLookUpDropDownFormClassNameChanged(object sender, LookUpDropDownFormClassNameChangedEventArgs e)
        {
            if (PropertyValidator.IsDesignTime() ||
                string.IsNullOrEmpty(e.NewLookUpDropDownFormClassName)
                ) return;
            ViewModel.DropDownFormClassName = e.NewLookUpDropDownFormClassName;
        }
    }
}
