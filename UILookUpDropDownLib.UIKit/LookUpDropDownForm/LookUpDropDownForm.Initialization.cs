using C1.Win.C1Input;

namespace UILookUpDropDownLib.UIKit.LookUpDropDownForm
{
    public class LookUpDropDownForm : DropDownForm
    {
        private LookUpDataGridView.LookUpDataGridView lookUpDataGridView1;

        public LookUpDropDownForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lookUpDataGridView1 = new UILookUpDropDownLib.UIKit.LookUpDataGridView.LookUpDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpDataGridView1
            // 
            this.lookUpDataGridView1.AllowUserToAddRows = false;
            this.lookUpDataGridView1.AllowUserToDeleteRows = false;
            this.lookUpDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lookUpDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lookUpDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.lookUpDataGridView1.Name = "lookUpDataGridView1";
            this.lookUpDataGridView1.RowHeadersVisible = false;
            this.lookUpDataGridView1.RowHeadersWidth = 51;
            this.lookUpDataGridView1.RowTemplate.Height = 24;
            this.lookUpDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lookUpDataGridView1.Size = new System.Drawing.Size(240, 250);
            this.lookUpDataGridView1.TabIndex = 0;
            // 
            // LookUpDropDownForm
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientSize = new System.Drawing.Size(240, 250);
            this.Controls.Add(this.lookUpDataGridView1);
            this.Name = "LookUpDropDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
