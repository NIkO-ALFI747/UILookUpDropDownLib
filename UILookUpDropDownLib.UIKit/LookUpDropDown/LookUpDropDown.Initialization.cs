using C1.Win.C1Input;
using UILookUpDropDownLib.Abstractions.View;
using UILookUpDropDownLib.ViewAdapter;

namespace UILookUpDropDownLib.UIKit.LookUpDropDown
{
    public partial class LookUpDropDown : C1DropDownControl, ILookUpDropDownView
    {
        public LookUpDropDown()
        {
            InitializeComponent();
            LookUpDropDownViewAdapter = new LookUpDropDownViewAdapter(this);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpDropDown
            // 
            this.AutoSize = false;
            this.VisibleButtons = ((C1.Win.C1Input.DropDownControlButtonFlags)((C1.Win.C1Input.DropDownControlButtonFlags.DropDown | C1.Win.C1Input.DropDownControlButtonFlags.Modal)));
            this.BeforeDropDownOpen += new System.ComponentModel.CancelEventHandler(this.LookUpDropDown_BeforeDropDownOpen);
            this.DropDownOpened += new System.EventHandler(this.LookUpDropDown_DropDownOpened);
            this.DropDownClosed += new C1.Win.C1Input.DropDownClosedEventHandler(this.LookUpDropDown_DropDownClosed);
            this.UpDownButtonClick += new C1.Win.C1Input.UpDownButtonClickEventHandler(this.LookUpDropDown_UpDownButtonClick);
            this.TextChanged += new System.EventHandler(this.LookUpDropDown_TextChanged);
            this.Leave += new System.EventHandler(this.LookUpDropDown_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LookUpDropDown_MouseDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LookUpDropDown_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
