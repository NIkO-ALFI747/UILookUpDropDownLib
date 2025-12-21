using System.Windows.Forms;
using UILookUpDropDownLib.Abstractions.View;

namespace UILookUpDropDownLib.UIKit.LookUpDataGridView
{
    public partial class LookUpDataGridView : DataGridView, ILookUpDataGridView
    {
        public LookUpDataGridView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpDataGridView
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 24;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(240, 250);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
