namespace lr18_2
{
    partial class lr18_2
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
            this.btnNewStringEvenIndex = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtNewString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewStringEvenIndex
            // 
            this.btnNewStringEvenIndex.Location = new System.Drawing.Point(137, 100);
            this.btnNewStringEvenIndex.Name = "btnNewStringEvenIndex";
            this.btnNewStringEvenIndex.Size = new System.Drawing.Size(200, 23);
            this.btnNewStringEvenIndex.TabIndex = 0;
            this.btnNewStringEvenIndex.Text = "Сформировать новую строку";
            this.btnNewStringEvenIndex.UseVisualStyleBackColor = true;
            this.btnNewStringEvenIndex.Click += new System.EventHandler(this.btnNewStringEvenIndex_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(112, 74);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(266, 20);
            this.txtString.TabIndex = 1;
            // 
            // txtNewString
            // 
            this.txtNewString.Location = new System.Drawing.Point(112, 142);
            this.txtNewString.Name = "txtNewString";
            this.txtNewString.Size = new System.Drawing.Size(266, 20);
            this.txtNewString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите строку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строка результат";
            // 
            // lr18_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewString);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnNewStringEvenIndex);
            this.Name = "lr18_2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewStringEvenIndex;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtNewString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

