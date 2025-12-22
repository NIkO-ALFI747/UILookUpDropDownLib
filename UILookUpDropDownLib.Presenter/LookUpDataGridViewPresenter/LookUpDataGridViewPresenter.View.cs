using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Presenter.LookUpDataGridViewPresenter
{
    partial class LookUpDataGridViewPresenter<TModel>
    {
        private ILookUpDataGridView _view;

        public ILookUpDataGridView View
        {
            private get => _view;
            set
            {
                var viewChangingEventArgs = new PropertyChangingEventArgs<ILookUpDataGridView>(_view, value);
                ViewChanging?.Invoke(this, viewChangingEventArgs);
                if (viewChangingEventArgs.Cancel) return;
                _view = value;
                ViewChanged?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
