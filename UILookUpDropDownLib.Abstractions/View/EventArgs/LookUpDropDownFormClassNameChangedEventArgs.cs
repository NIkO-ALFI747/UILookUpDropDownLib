namespace UILookUpDropDownLib.Abstractions.View.EventArgs
{
    public class LookUpDropDownFormClassNameChangedEventArgs : System.EventArgs
    {
        public string NewLookUpDropDownFormClassName { get; }

        public LookUpDropDownFormClassNameChangedEventArgs(string newLookUpDropDownFormClassName)
        {
            NewLookUpDropDownFormClassName = newLookUpDropDownFormClassName;
        }
    }
}
