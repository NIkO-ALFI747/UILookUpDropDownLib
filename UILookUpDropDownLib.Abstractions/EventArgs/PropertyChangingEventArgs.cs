namespace UILookUpDropDownLib.Abstractions.EventArgs
{
    public class PropertyChangingEventArgs<TProperty> : System.EventArgs
    {
        public TProperty OldValue { get; }

        public TProperty NewValue { get; }

        public bool Cancel { get; set; }

        public PropertyChangingEventArgs(
            TProperty oldValue,
            TProperty newValue
            )
        {
            OldValue = oldValue;
            NewValue = newValue;
            Cancel = false;
        }
    }
}
