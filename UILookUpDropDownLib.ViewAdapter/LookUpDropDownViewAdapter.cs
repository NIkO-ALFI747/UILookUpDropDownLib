using C1.Win.C1Input;
using UILookUpDropDownLib.Abstractions.ViewAdapter;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.ViewAdapter.Utils;

namespace UILookUpDropDownLib.ViewAdapter
{
    public class LookUpDropDownViewAdapter : ILookUpDropDownViewAdapter
    {
        private DataBinder DataBinder { get; set; }

        private C1DropDownControl View { get; set; }

        public LookUpDropDownViewAdapter(C1DropDownControl view)
        {
            DataBinder = new DataBinder();
            View = view;
        }

        public void BindData(ILookUpDropDownViewModel viewModel)
        {
            DataBinder.BindData(viewModel, View);
        }
    }
}
