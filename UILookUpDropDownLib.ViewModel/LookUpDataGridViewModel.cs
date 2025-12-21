using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.ViewModel
{
    public class LookUpDataGridViewModel<TModel> : ObservableObject, ILookUpDataGridViewModel<TModel>
    {
        private IEnumerable<TModel> _dataCollection;
        private IDictionary<string, string> _columnMappings;

        public IEnumerable<TModel> DataCollection
        {
            get => _dataCollection;
            set => SetProperty(ref _dataCollection, value);
        }

        public IDictionary<string, string> ColumnMappings
        {
            get => _columnMappings;
            set => SetProperty(ref _columnMappings, value);
        }
    }
}
