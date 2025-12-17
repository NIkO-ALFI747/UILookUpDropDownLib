using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using UILookUpDropDownLib.Abstractions.ViewModel;

namespace UILookUpDropDownLib.ViewModel
{
    public class LookUpDropDownViewModel : ObservableObject, ILookUpDropDownViewModel
    {
        private string _searchText;

        public string SearchText {
            get => _searchText;
            set
            {
                SetProperty(ref _searchText, value);
                Debug.WriteLine($"ViewModel SearchText: {_searchText}");
            }
        }
    }
}
