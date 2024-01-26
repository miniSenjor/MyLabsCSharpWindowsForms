
namespace z2
{
    partial class frmSqr
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
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.edit1 = new System.Windows.Forms.TextBox();
            this.edit2 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.edit3 = new System.Windows.Forms.TextBox();
            this.btnF = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(48, 54);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(281, 21);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Площадь треугольника по 3 сторонам";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(48, 93);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(200, 21);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "Площадь прямоугольника";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(48, 131);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(324, 21);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "Площадь треугольника по 2 сторонам и углу";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(48, 168);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(148, 21);
            this.radio4.TabIndex = 3;
            this.radio4.TabStop = true;
            this.radio4.Text = "Процент от числа";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio4_CheckedChanged);
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(48, 221);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(85, 22);
            this.txt1.TabIndex = 4;
            this.txt1.Text = "сторона 1=";
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(139, 221);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(63, 22);
            this.edit1.TabIndex = 5;
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(321, 220);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(70, 22);
            this.edit2.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(233, 220);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(82, 22);
            this.txt2.TabIndex = 7;
            this.txt2.Text = "сторона 2=";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(413, 220);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(82, 22);
            this.txt3.TabIndex = 9;
            this.txt3.Text = "сторона 3=";
            // 
            // edit3
            // 
            this.edit3.Location = new System.Drawing.Point(501, 220);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(70, 22);
            this.edit3.TabIndex = 8;
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(48, 263);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(95, 23);
            this.btnF.TabIndex = 10;
            this.btnF.Text = "Вычислить";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(200, 263);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(100, 22);
            this.txtExit.TabIndex = 11;
            // 
            // frmSqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Name = "frmSqr";
            this.Text = "z2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox edit1;
        private System.Windows.Forms.TextBox edit2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox edit3;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.TextBox txtExit;
    }
}

