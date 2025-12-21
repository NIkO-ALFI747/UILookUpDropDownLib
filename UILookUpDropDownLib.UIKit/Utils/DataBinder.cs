using C1.Win.C1Input;
using System.Windows.Forms;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.UIKit.Utils
{
    internal class DataBinder
    {
        public void BindData(ILookUpDropDownViewModel viewModel, C1DropDownControl c1DropDownControl)
        {
            c1DropDownControl.DataBindings.Clear();
            c1DropDownControl.DataBindings.Add(
                nameof(C1DropDownControl.Text),
                viewModel,
                nameof(ILookUpDropDownViewModel.SearchText),
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );
            c1DropDownControl.DataBindings.Add(
                nameof(C1DropDownControl.DropDownFormClassName),
                viewModel,
                nameof(ILookUpDropDownViewModel.DropDownFormClassName),
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );
        }
    }
}