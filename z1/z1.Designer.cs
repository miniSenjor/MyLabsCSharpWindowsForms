
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLettters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 19);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(54, 91);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(54, 129);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "От кого";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(65, 29);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(31, 17);
            this.rB1.TabIndex = 4;
            this.rB1.TabStop = true;
            this.rB1.Text = "1";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(102, 29);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(31, 17);
            this.rB2.TabIndex = 5;
            this.rB2.TabStop = true;
            this.rB2.Text = "2";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(139, 29);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(31, 17);
            this.rB3.TabIndex = 6;
            this.rB3.TabStop = true;
            this.rB3.Text = "3";
            this.rB3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кому";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип";
            // 
            // txtLettters
            // 
            this.txtLettters.Location = new System.Drawing.Point(311, 91);
            this.txtLettters.Multiline = true;
            this.txtLettters.Name = "txtLettters";
            this.txtLettters.Size = new System.Drawing.Size(268, 103);
            this.txtLettters.TabIndex = 9;
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtLettters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rB3);
            this.Controls.Add(this.rB2);
            this.Controls.Add(this.rB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "z1";
            this.Text = "lr23z1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLettters;
    }
}

