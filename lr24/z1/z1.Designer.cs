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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbA = new System.Windows.Forms.ListBox();
            this.lbB = new System.Windows.Forms.ListBox();
            this.lbC = new System.Windows.Forms.ListBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.Location = new System.Drawing.Point(19, 138);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(95, 134);
            this.lbA.TabIndex = 1;
            // 
            // lbB
            // 
            this.lbB.FormattingEnabled = true;
            this.lbB.Location = new System.Drawing.Point(120, 138);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(95, 134);
            this.lbB.TabIndex = 2;
            // 
            // lbC
            // 
            this.lbC.FormattingEnabled = true;
            this.lbC.Location = new System.Drawing.Point(223, 138);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(95, 134);
            this.lbC.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(41, 122);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "a=";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(156, 122);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "b=";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(258, 122);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(19, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::z1.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.btnStart);
            this.Name = "z1";
            this.Text = "lr24z1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.ListBox lbB;
        private System.Windows.Forms.ListBox lbC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

