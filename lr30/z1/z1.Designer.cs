namespace z1
{
    partial class z1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbRates = new System.Windows.Forms.ListBox();
            this.btnWriteRates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lbRates
            // 
            this.lbRates.FormattingEnabled = true;
            this.lbRates.Location = new System.Drawing.Point(227, 21);
            this.lbRates.Name = "lbRates";
            this.lbRates.Size = new System.Drawing.Size(120, 212);
            this.lbRates.TabIndex = 1;
            // 
            // btnWriteRates
            // 
            this.btnWriteRates.Location = new System.Drawing.Point(19, 210);
            this.btnWriteRates.Name = "btnWriteRates";
            this.btnWriteRates.Size = new System.Drawing.Size(75, 23);
            this.btnWriteRates.TabIndex = 2;
            this.btnWriteRates.Text = "ОК";
            this.btnWriteRates.UseVisualStyleBackColor = true;
            this.btnWriteRates.Click += new System.EventHandler(this.btnWriteRates_Click);
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 256);
            this.Controls.Add(this.btnWriteRates);
            this.Controls.Add(this.lbRates);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "z1";
            this.Text = "lr30z1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lbRates;
        private System.Windows.Forms.Button btnWriteRates;
    }
}

