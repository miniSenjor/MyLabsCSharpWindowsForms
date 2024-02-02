namespace lr18
{
    partial class lr18
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
            this.btnMakeName = new System.Windows.Forms.Button();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRepeatLetters = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMakeName
            // 
            this.btnMakeName.Location = new System.Drawing.Point(283, 81);
            this.btnMakeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeName.Name = "btnMakeName";
            this.btnMakeName.Size = new System.Drawing.Size(196, 28);
            this.btnMakeName.TabIndex = 0;
            this.btnMakeName.Text = "Можно ли составть имя";
            this.btnMakeName.UseVisualStyleBackColor = true;
            this.btnMakeName.Click += new System.EventHandler(this.btnMakeName_Click);
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(109, 81);
            this.txtLetters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(132, 22);
            this.txtLetters.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 145);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Буквы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Составить имя ...";
            // 
            // checkRepeatLetters
            // 
            this.checkRepeatLetters.AutoSize = true;
            this.checkRepeatLetters.Location = new System.Drawing.Point(109, 209);
            this.checkRepeatLetters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkRepeatLetters.Name = "checkRepeatLetters";
            this.checkRepeatLetters.Size = new System.Drawing.Size(318, 21);
            this.checkRepeatLetters.TabIndex = 6;
            this.checkRepeatLetters.Text = "Буквы могут использоваться несколько раз";
            this.checkRepeatLetters.UseVisualStyleBackColor = true;
            // 
            // lr18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 298);
            this.Controls.Add(this.checkRepeatLetters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLetters);
            this.Controls.Add(this.btnMakeName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "lr18";
            this.Text = "lr18z1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeName;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkRepeatLetters;
    }
}

