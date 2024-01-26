
namespace lr1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 201);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "ВЫход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(38, 47);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(140, 46);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(253, 47);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(76, 20);
            this.txtC.TabIndex = 3;
            this.txtC.Text = "0";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(38, 102);
            this.txtSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(76, 20);
            this.txtSum.TabIndex = 4;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(211, 101);
            this.btnCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(76, 19);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Вычислить";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "z1";
            this.Text = "z1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnCount;
    }
}

