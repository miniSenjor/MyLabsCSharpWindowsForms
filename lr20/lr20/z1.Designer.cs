
namespace lr20
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSelectionFIle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 136);
            this.textBox1.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(166, 36);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(85, 19);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSelectionFIle
            // 
            this.btnSelectionFIle.Location = new System.Drawing.Point(40, 36);
            this.btnSelectionFIle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectionFIle.Name = "btnSelectionFIle";
            this.btnSelectionFIle.Size = new System.Drawing.Size(86, 19);
            this.btnSelectionFIle.TabIndex = 3;
            this.btnSelectionFIle.Text = "Выбрать файл";
            this.btnSelectionFIle.UseVisualStyleBackColor = true;
            this.btnSelectionFIle.Click += new System.EventHandler(this.btnSelectionFIle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строк в начале и в конце которых один символ:";
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSelectionFIle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "z1";
            this.Text = "lr20z1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSelectionFIle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

