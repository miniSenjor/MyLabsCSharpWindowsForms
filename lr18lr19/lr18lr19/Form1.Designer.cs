namespace lr18lr19
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
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn10Convert2 = new System.Windows.Forms.Button();
            this.btn2Convert10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(160, 71);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(100, 20);
            this.txt10.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "10-ая сс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2-ая сс";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(160, 113);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            // 
            // btn10Convert2
            // 
            this.btn10Convert2.Location = new System.Drawing.Point(184, 151);
            this.btn10Convert2.Name = "btn10Convert2";
            this.btn10Convert2.Size = new System.Drawing.Size(75, 23);
            this.btn10Convert2.TabIndex = 5;
            this.btn10Convert2.Text = "Из 10 в 2";
            this.btn10Convert2.UseVisualStyleBackColor = true;
            this.btn10Convert2.Click += new System.EventHandler(this.btn10Convert2_Click);
            // 
            // btn2Convert10
            // 
            this.btn2Convert10.Location = new System.Drawing.Point(80, 151);
            this.btn2Convert10.Name = "btn2Convert10";
            this.btn2Convert10.Size = new System.Drawing.Size(75, 23);
            this.btn2Convert10.TabIndex = 6;
            this.btn2Convert10.Text = "Из 2 в 10";
            this.btn2Convert10.UseVisualStyleBackColor = true;
            this.btn2Convert10.Click += new System.EventHandler(this.btn2Convert10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 237);
            this.Controls.Add(this.btn2Convert10);
            this.Controls.Add(this.btn10Convert2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn10Convert2;
        private System.Windows.Forms.Button btn2Convert10;
    }
}

