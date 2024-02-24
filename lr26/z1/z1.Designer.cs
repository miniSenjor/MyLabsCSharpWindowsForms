
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
            this.label3 = new System.Windows.Forms.Label();
            this.lBCows = new System.Windows.Forms.ListBox();
            this.lBBulls = new System.Windows.Forms.ListBox();
            this.lBYourOptions = new System.Windows.Forms.ListBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYourNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBAICows = new System.Windows.Forms.ListBox();
            this.lBAIBulls = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lBAIOption = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartAI = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYourStart
            // 
            this.btnYourStart.Location = new System.Drawing.Point(74, 220);
            this.btnYourStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lBCows);
            this.groupBox1.Controls.Add(this.lBBulls);
            this.groupBox1.Controls.Add(this.btnYourStart);
            this.groupBox1.Controls.Add(this.lBYourOptions);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // lBCows
            // 
            this.lBCows.FormattingEnabled = true;
            this.lBCows.Location = new System.Drawing.Point(117, 38);
            this.lBCows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBCows.Name = "lBCows";
            this.lBCows.Size = new System.Drawing.Size(41, 147);
            this.lBCows.TabIndex = 13;
            // 
            // lBBulls
            // 
            this.lBBulls.FormattingEnabled = true;
            this.lBBulls.Location = new System.Drawing.Point(74, 38);
            this.lBBulls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBBulls.Name = "lBBulls";
            this.lBBulls.Size = new System.Drawing.Size(39, 147);
            this.lBBulls.TabIndex = 12;
            // 
            // lBYourOptions
            // 
            this.lBYourOptions.FormattingEnabled = true;
            this.lBYourOptions.Location = new System.Drawing.Point(0, 39);
            this.lBYourOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBYourOptions.Name = "lBYourOptions";
            this.lBYourOptions.Size = new System.Drawing.Size(67, 147);
            this.lBYourOptions.TabIndex = 10;
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(82, 189);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(56, 19);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(0, 189);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // txtYourNumber
            // 
            this.txtYourNumber.Location = new System.Drawing.Point(79, 22);
            this.txtYourNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYourNumber.Name = "txtYourNumber";
            this.txtYourNumber.Size = new System.Drawing.Size(66, 20);
            this.txtYourNumber.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBAICows);
            this.groupBox2.Controls.Add(this.lBAIBulls);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lBAIOption);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
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
            // lBAICows
            // 
            this.lBAICows.FormattingEnabled = true;
            this.lBAICows.Location = new System.Drawing.Point(124, 59);
            this.lBAICows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBAICows.Name = "lBAICows";
            this.lBAICows.Size = new System.Drawing.Size(40, 147);
            this.lBAICows.TabIndex = 17;
            // 
            // lBAIBulls
            // 
            this.lBAIBulls.FormattingEnabled = true;
            this.lBAIBulls.Location = new System.Drawing.Point(81, 59);
            this.lBAIBulls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBAIBulls.Name = "lBAIBulls";
            this.lBAIBulls.Size = new System.Drawing.Size(40, 147);
            this.lBAIBulls.TabIndex = 15;
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
            // lBAIOption
            // 
            this.lBAIOption.FormattingEnabled = true;
            this.lBAIOption.Location = new System.Drawing.Point(11, 59);
            this.lBAIOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBAIOption.Name = "lBAIOption";
            this.lBAIOption.Size = new System.Drawing.Size(66, 147);
            this.lBAIOption.TabIndex = 14;
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
            // btnStartAI
            // 
            this.btnStartAI.Location = new System.Drawing.Point(12, 219);
            this.btnStartAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartAI.Name = "btnStartAI";
            this.btnStartAI.Size = new System.Drawing.Size(80, 19);
            this.btnStartAI.TabIndex = 10;
            this.btnStartAI.Text = "Играть";
            this.btnStartAI.UseVisualStyleBackColor = true;
            this.btnStartAI.Click += new System.EventHandler(this.btnStartAI_Click);
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYourNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartAI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBCows;
        private System.Windows.Forms.ListBox lBBulls;
        private System.Windows.Forms.ListBox lBYourOptions;
        private System.Windows.Forms.ListBox lBAIOption;
        private System.Windows.Forms.ListBox lBAIBulls;
        private System.Windows.Forms.ListBox lBAICows;
    }
}

