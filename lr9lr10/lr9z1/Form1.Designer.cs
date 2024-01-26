namespace lr9z1
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
            this.btnImport = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(412, 142);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(87, 38);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Загрузить изображение";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(81, 26);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(300, 315);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 1;
            this.pct.TabStop = false;
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // txtIm
            // 
            this.txtIm.Location = new System.Drawing.Point(81, 361);
            this.txtIm.Name = "txtIm";
            this.txtIm.ReadOnly = true;
            this.txtIm.Size = new System.Drawing.Size(300, 20);
            this.txtIm.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(412, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить изображение";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIm);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.btnImport);
            this.Name = "Form1";
            this.Text = "lr9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
    }
}

