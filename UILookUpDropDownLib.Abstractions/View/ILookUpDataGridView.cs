using UILookUpDropDownLib.Abstractions.ViewAdapter;

namespace UILookUpDropDownLib.Abstractions.View
{
    public interface ILookUpDataGridView
    {
        ILookUpDataGridViewAdapter LookUpDataGridViewAdapter { get; set; }
    }
}
