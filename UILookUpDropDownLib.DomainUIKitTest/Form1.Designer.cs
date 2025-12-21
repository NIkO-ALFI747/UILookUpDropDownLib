namespace UILookUpDropDownLib.DomainUIKitTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1DropDownControl1 = new C1.Win.C1Input.C1DropDownControl();
            this.counterpartyLookUpDropDown1 = new UILookUpDropDownLib.DomainUIKit.CounterpartyLookUpDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyLookUpDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.GapHeight = 0;
            this.c1DropDownControl1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DropDownControl1.Location = new System.Drawing.Point(17, 16);
            this.c1DropDownControl1.Margin = new System.Windows.Forms.Padding(4);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(267, 22);
            this.c1DropDownControl1.TabIndex = 0;
            this.c1DropDownControl1.Tag = null;
            // 
            // counterpartyLookUpDropDown1
            // 
            this.counterpartyLookUpDropDown1.AutoSize = false;
            this.counterpartyLookUpDropDown1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.counterpartyLookUpDropDown1.Location = new System.Drawing.Point(17, 74);
            this.counterpartyLookUpDropDown1.LookUpDropDownFormClassName = "UILookUpDropDownLib.UIKit.LookUpDropDownForm.LookUpDropDownForm";
            this.counterpartyLookUpDropDown1.Name = "counterpartyLookUpDropDown1";
            this.counterpartyLookUpDropDown1.Size = new System.Drawing.Size(267, 24);
            this.counterpartyLookUpDropDown1.TabIndex = 1;
            this.counterpartyLookUpDropDown1.Tag = null;
            this.counterpartyLookUpDropDown1.ViewModel = null;
            this.counterpartyLookUpDropDown1.VisibleButtons = ((C1.Win.C1Input.DropDownControlButtonFlags)((C1.Win.C1Input.DropDownControlButtonFlags.DropDown | C1.Win.C1Input.DropDownControlButtonFlags.Modal)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.counterpartyLookUpDropDown1);
            this.Controls.Add(this.c1DropDownControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartyLookUpDropDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
        private DomainUIKit.CounterpartyLookUpDropDown counterpartyLookUpDropDown1;
    }
}

