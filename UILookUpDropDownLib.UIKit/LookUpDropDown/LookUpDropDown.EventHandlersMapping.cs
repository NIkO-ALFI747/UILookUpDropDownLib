using C1.Win.C1Input;
using System;

namespace UILookUpDropDownLib.UIKit.LookUpDropDown
{
    public partial class LookUpDropDown
    {
        private void LookUpDropDown_BeforeDropDownOpen(object sender, System.ComponentModel.CancelEventArgs e)
            => BeforeLookUpDropDownOpened?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_DropDownClosed(object sender, DropDownClosedEventArgs e)
            => LookUpDropDownClosed?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_DropDownOpened(object sender, EventArgs e)
            => LookUpDropDownOpened?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_UpDownButtonClick(object sender, UpDownButtonClickEventArgs e)
            => LookUpUpDownButtonClick?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_TextChanged(object sender, EventArgs e)
            => SearchTextChanged?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_Leave(object sender, EventArgs e)
            => LookUpLeave?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
            => LookUpMouseDown?.Invoke(this, EventArgs.Empty);

        private void LookUpDropDown_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
            => LookUpPreviewKeyDown?.Invoke(this, EventArgs.Empty);
    }
}
