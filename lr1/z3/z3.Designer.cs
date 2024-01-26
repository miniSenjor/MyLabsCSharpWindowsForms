
namespace z3
{
    partial class z3
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
            this.lst = new System.Windows.Forms.ListBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.lstWidth = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(46, 65);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(120, 84);
            this.lst.TabIndex = 0;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(46, 204);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 22);
            this.txt.TabIndex = 1;
            // 
            // lstWidth
            // 
            this.lstWidth.FormattingEnabled = true;
            this.lstWidth.ItemHeight = 16;
            this.lstWidth.Location = new System.Drawing.Point(215, 65);
            this.lstWidth.Name = "lstWidth";
            this.lstWidth.Size = new System.Drawing.Size(120, 84);
            this.lstWidth.TabIndex = 2;
            this.lstWidth.SelectedIndexChanged += new System.EventHandler(this.lstWidth_SelectedIndexChanged);
            // 
            // z3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstWidth);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lst);
            this.Name = "z3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ListBox lstWidth;
    }
}

