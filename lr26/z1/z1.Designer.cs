
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartAI = new System.Windows.Forms.Button();
            this.lBAIOption = new System.Windows.Forms.ListBox();
            this.lBAIBulls = new System.Windows.Forms.ListBox();
            this.lBAICows = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYourStart
            // 
            this.btnYourStart.Location = new System.Drawing.Point(99, 271);
            this.btnYourStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYourStart.Name = "btnYourStart";
            this.btnYourStart.Size = new System.Drawing.Size(107, 23);
            this.btnYourStart.TabIndex = 0;
            this.btnYourStart.Text = "Новая игра";
            this.btnYourStart.UseVisualStyleBackColor = true;
            this.btnYourStart.Click += new System.EventHandler(this.btnYourStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вы отгадываете";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "коровы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "быки";
            // 
            // lBCows
            // 
            this.lBCows.FormattingEnabled = true;
            this.lBCows.ItemHeight = 16;
            this.lBCows.Location = new System.Drawing.Point(156, 47);
            this.lBCows.Name = "lBCows";
            this.lBCows.Size = new System.Drawing.Size(53, 180);
            this.lBCows.TabIndex = 13;
            // 
            // lBBulls
            // 
            this.lBBulls.FormattingEnabled = true;
            this.lBBulls.ItemHeight = 16;
            this.lBBulls.Location = new System.Drawing.Point(99, 47);
            this.lBBulls.Name = "lBBulls";
            this.lBBulls.Size = new System.Drawing.Size(51, 180);
            this.lBBulls.TabIndex = 12;
            // 
            // lBYourOptions
            // 
            this.lBYourOptions.FormattingEnabled = true;
            this.lBYourOptions.ItemHeight = 16;
            this.lBYourOptions.Location = new System.Drawing.Point(0, 48);
            this.lBYourOptions.Name = "lBYourOptions";
            this.lBYourOptions.Size = new System.Drawing.Size(88, 180);
            this.lBYourOptions.TabIndex = 10;
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(110, 233);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(0, 233);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(87, 22);
            this.txtInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваше число";
            // 
            // txtYourNumber
            // 
            this.txtYourNumber.Location = new System.Drawing.Point(105, 27);
            this.txtYourNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYourNumber.Name = "txtYourNumber";
            this.txtYourNumber.Size = new System.Drawing.Size(87, 22);
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
            this.groupBox2.Location = new System.Drawing.Point(275, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(239, 311);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ИИ отгадывает";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "коровы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "быки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Число";
            // 
            // btnStartAI
            // 
            this.btnStartAI.Location = new System.Drawing.Point(16, 270);
            this.btnStartAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartAI.Name = "btnStartAI";
            this.btnStartAI.Size = new System.Drawing.Size(107, 23);
            this.btnStartAI.TabIndex = 10;
            this.btnStartAI.Text = "Новая игра";
            this.btnStartAI.UseVisualStyleBackColor = true;
            this.btnStartAI.Click += new System.EventHandler(this.btnStartAI_Click);
            // 
            // lBAIOption
            // 
            this.lBAIOption.FormattingEnabled = true;
            this.lBAIOption.ItemHeight = 16;
            this.lBAIOption.Location = new System.Drawing.Point(15, 73);
            this.lBAIOption.Name = "lBAIOption";
            this.lBAIOption.Size = new System.Drawing.Size(87, 180);
            this.lBAIOption.TabIndex = 14;
            // 
            // lBAIBulls
            // 
            this.lBAIBulls.FormattingEnabled = true;
            this.lBAIBulls.ItemHeight = 16;
            this.lBAIBulls.Location = new System.Drawing.Point(108, 73);
            this.lBAIBulls.Name = "lBAIBulls";
            this.lBAIBulls.Size = new System.Drawing.Size(52, 180);
            this.lBAIBulls.TabIndex = 15;
            // 
            // lBAICows
            // 
            this.lBAICows.FormattingEnabled = true;
            this.lBAICows.ItemHeight = 16;
            this.lBAICows.Location = new System.Drawing.Point(166, 73);
            this.lBAICows.Name = "lBAICows";
            this.lBAICows.Size = new System.Drawing.Size(52, 180);
            this.lBAICows.TabIndex = 17;
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

