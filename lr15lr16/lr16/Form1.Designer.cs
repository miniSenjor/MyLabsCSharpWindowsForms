
namespace lr16
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.runningText1 = new lr16.RunningText();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите слово";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(88, 165);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(102, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(231, 90);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(100, 22);
            this.txtStr.TabIndex = 5;
            // 
            // runningText1
            // 
            this.runningText1.Location = new System.Drawing.Point(0, 1);
            this.runningText1.Name = "runningText1";
            this.runningText1.Size = new System.Drawing.Size(516, 26);
            this.runningText1.TabIndex = 4;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(231, 136);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtSpeed.TabIndex = 6;
            this.txtSpeed.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Скорость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.runningText1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "lr16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private RunningText runningText1;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label1;
    }
}

