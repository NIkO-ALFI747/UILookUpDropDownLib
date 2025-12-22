using C1.Win.C1Input;
using System.Windows.Forms;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.ViewAdapter.Utils
{
    public class DataBinder
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

        public void BindGridData<TModel>(ILookUpDataGridViewModel<TModel> viewModel, DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();
            if (viewModel.ColumnMappings != null)
            {
                foreach (var mapping in viewModel.ColumnMappings)
                {
                    var col = new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = mapping.Key,
                        HeaderText = mapping.Value,
                        Name = mapping.Key
                    };
                    grid.Columns.Add(col);
                }
            }
            var bindingSource = new BindingSource
            {
                DataSource = viewModel.DataCollection
            };
            grid.DataSource = bindingSource;
        }
    }
}