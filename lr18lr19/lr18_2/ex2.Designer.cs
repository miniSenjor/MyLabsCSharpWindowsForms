namespace lr18_2
{
    partial class ex2
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
            this.btnNewStringEvenIndex.Location = new System.Drawing.Point(183, 123);
            this.btnNewStringEvenIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewStringEvenIndex.Name = "btnNewStringEvenIndex";
            this.btnNewStringEvenIndex.Size = new System.Drawing.Size(267, 28);
            this.btnNewStringEvenIndex.TabIndex = 0;
            this.btnNewStringEvenIndex.Text = "Сформировать новую строку";
            this.btnNewStringEvenIndex.UseVisualStyleBackColor = true;
            this.btnNewStringEvenIndex.Click += new System.EventHandler(this.btnNewStringEvenIndex_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(149, 91);
            this.txtString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(353, 22);
            this.txtString.TabIndex = 1;
            // 
            // txtNewString
            // 
            this.txtNewString.Location = new System.Drawing.Point(149, 175);
            this.txtNewString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewString.Name = "txtNewString";
            this.txtNewString.Size = new System.Drawing.Size(353, 22);
            this.txtNewString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите строку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строка результат";
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewString);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnNewStringEvenIndex);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ex2";
            this.Text = "lr18ex2";
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

