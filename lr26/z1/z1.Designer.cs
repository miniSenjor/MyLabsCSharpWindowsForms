
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
            this.btnYourStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCows = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBulls = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYourOptions = new System.Windows.Forms.TextBox();
            this.txtYourNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnStartAI = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYourStart
            // 
            this.btnYourStart.Location = new System.Drawing.Point(74, 220);
            this.btnYourStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnYourStart.Name = "btnYourStart";
            this.btnYourStart.Size = new System.Drawing.Size(80, 19);
            this.btnYourStart.TabIndex = 0;
            this.btnYourStart.Text = "Новая игра";
            this.btnYourStart.UseVisualStyleBackColor = true;
            this.btnYourStart.Click += new System.EventHandler(this.btnYourStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваше число:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCows);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnYourStart);
            this.groupBox1.Controls.Add(this.txtBulls);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYourOptions);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(191, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вы отгадываете";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "коровы";
            // 
            // txtCows
            // 
            this.txtCows.Location = new System.Drawing.Point(117, 38);
            this.txtCows.Margin = new System.Windows.Forms.Padding(2);
            this.txtCows.Multiline = true;
            this.txtCows.Name = "txtCows";
            this.txtCows.Size = new System.Drawing.Size(39, 142);
            this.txtCows.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "быки";
            // 
            // txtBulls
            // 
            this.txtBulls.Location = new System.Drawing.Point(74, 39);
            this.txtBulls.Margin = new System.Windows.Forms.Padding(2);
            this.txtBulls.Multiline = true;
            this.txtBulls.Name = "txtBulls";
            this.txtBulls.Size = new System.Drawing.Size(39, 142);
            this.txtBulls.TabIndex = 6;
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(84, 184);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(56, 19);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(4, 185);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(66, 20);
            this.txtInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваше число";
            // 
            // txtYourOptions
            // 
            this.txtYourOptions.Location = new System.Drawing.Point(4, 39);
            this.txtYourOptions.Margin = new System.Windows.Forms.Padding(2);
            this.txtYourOptions.Multiline = true;
            this.txtYourOptions.Name = "txtYourOptions";
            this.txtYourOptions.Size = new System.Drawing.Size(66, 142);
            this.txtYourOptions.TabIndex = 0;
            // 
            // txtYourNumber
            // 
            this.txtYourNumber.Location = new System.Drawing.Point(79, 22);
            this.txtYourNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtYourNumber.Name = "txtYourNumber";
            this.txtYourNumber.Size = new System.Drawing.Size(66, 20);
            this.txtYourNumber.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btnStartAI);
            this.groupBox2.Controls.Add(this.txtYourNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(206, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 253);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ИИ отгадывает";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "коровы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 142);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "быки";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 142);
            this.textBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Число";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 60);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 142);
            this.textBox3.TabIndex = 11;
            // 
            // btnStartAI
            // 
            this.btnStartAI.Location = new System.Drawing.Point(12, 219);
            this.btnStartAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartAI.Name = "btnStartAI";
            this.btnStartAI.Size = new System.Drawing.Size(80, 19);
            this.btnStartAI.TabIndex = 10;
            this.btnStartAI.Text = "Новая игра";
            this.btnStartAI.UseVisualStyleBackColor = true;
            this.btnStartAI.Click += new System.EventHandler(this.btnStartAI_Click);
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "z1";
            this.Text = "lr26z1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYourStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBulls;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYourOptions;
        private System.Windows.Forms.TextBox txtYourNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartAI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
    }
}

