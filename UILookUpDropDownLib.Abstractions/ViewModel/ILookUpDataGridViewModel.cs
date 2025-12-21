using System.Collections.Generic;

namespace UILookUpDropDownLib.Abstractions.ViewModel
{
    public interface ILookUpDataGridViewModel<TModel>
    {
        IEnumerable<TModel> DataCollection { get; set; }
        IDictionary<string, string> ColumnMappings { get; set; }
    }
}
