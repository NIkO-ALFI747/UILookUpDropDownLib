using UILookUpDropDownLib.Abstractions.EventArgs;
using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.Presenter.LookUpDropDownPresenter
{
    public partial class LookUpDropDownPresenter
    {
        private ILookUpDropDownView _view;

        public ILookUpDropDownView View
        {
            private get => _view;
            set
            {
                var viewChangingEventArgs = new PropertyChangingEventArgs<ILookUpDropDownView>(_view, value);
                ViewChanging?.Invoke(this, viewChangingEventArgs);
                if (viewChangingEventArgs.Cancel) return;
                _view = value;
                ViewChanged?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
