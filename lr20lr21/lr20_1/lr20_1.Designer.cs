﻿
namespace lr20_1
{
    partial class lr20_1
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
            this.btnSelectionFIle = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectionFIle
            // 
            this.btnSelectionFIle.Location = new System.Drawing.Point(39, 69);
            this.btnSelectionFIle.Name = "btnSelectionFIle";
            this.btnSelectionFIle.Size = new System.Drawing.Size(114, 23);
            this.btnSelectionFIle.TabIndex = 0;
            this.btnSelectionFIle.Text = "Выбрать файл";
            this.btnSelectionFIle.UseVisualStyleBackColor = true;
            this.btnSelectionFIle.Click += new System.EventHandler(this.btnSelectionFIle_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(208, 69);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(113, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 166);
            this.textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lr20_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSelectionFIle);
            this.Name = "lr20_1";
            this.Text = "lr20_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectionFIle;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
