namespace lr18
{
    partial class ex1
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
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(376, 159);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(155, 28);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "Разбить на слова";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(80, 60);
            this.txtString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(449, 22);
            this.txtString.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(376, 214);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(155, 28);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Отсортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(80, 132);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 148);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите строку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Массив слов:";
            // 
            // lr18_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnSplit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "lr18_1";
            this.Text = "lr18ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

