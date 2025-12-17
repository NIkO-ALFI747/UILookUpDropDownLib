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
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.GapHeight = 0;
            this.c1DropDownControl1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DropDownControl1.Location = new System.Drawing.Point(13, 13);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(200, 18);
            this.c1DropDownControl1.TabIndex = 0;
            this.c1DropDownControl1.Tag = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1DropDownControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
    }
}

