using System.Windows.Forms;
using UILookUpDropDownLib.Abstractions.ViewAdapter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.ViewAdapter.Utils;

namespace UILookUpDropDownLib.ViewAdapter
{
    public class LookUpDataGridViewAdapter : ILookUpDataGridViewAdapter
    {
        private DataBinder DataBinder { get; set; }

        private DataGridView View { get; set; }

        public LookUpDataGridViewAdapter(DataGridView view)
        {
            DataBinder = new DataBinder();
            View = view;
        }

        public void BindData<TModel>(ILookUpDataGridViewModel<TModel> viewModel)
        {
            DataBinder.BindGridData(viewModel, View);
        }
    }
}
