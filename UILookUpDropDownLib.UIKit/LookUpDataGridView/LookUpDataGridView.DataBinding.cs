using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View.EventArgs;
using UILookUpDropDownLib.Abstractions.ViewModel;
using UILookUpDropDownLib.UIKit.Utils;

namespace UILookUpDropDownLib.UIKit.LookUpDataGridView
{
    partial class LookUpDataGridView
    {
        /*private ILookUpDataGridViewModel _viewModel;

        public ILookUpDataGridViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                var lookUpViewModelChangingEventArgs = new PropertyChangingEventArgs<ILookUpDropDownViewModel>(_viewModel, value);
                LookUpViewModelChanging?.Invoke(this, lookUpViewModelChangingEventArgs);
                if (lookUpViewModelChangingEventArgs.Cancel) return;
                _viewModel = value;
                var lookUpViewModelChangedEventArgs = new LookUpViewModelChangedEventArgs(_viewModel);
                LookUpViewModelChanged?.Invoke(this, lookUpViewModelChangedEventArgs);
            }
        }

        private DataBinder DataBinder { get; set; }

        public void BindData()
        {
            DataBinder.BindGridData(_viewModel, this);
        }*/
    }
}
