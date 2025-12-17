using System.Windows.Forms;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.UIKit.Utils
{
    internal class DataBinder
    {
        public void BindData(ILookUpDropDownViewModel viewModel, TextBox textBox)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add(
                nameof(TextBox.Text),
                viewModel,
                nameof(ILookUpDropDownViewModel.SearchText),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}