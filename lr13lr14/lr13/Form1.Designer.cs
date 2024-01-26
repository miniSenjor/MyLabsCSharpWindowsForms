
namespace lr13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMasSort = new System.Windows.Forms.Label();
            this.btnNewMas = new System.Windows.Forms.Button();
            this.btnMasSort = new System.Windows.Forms.Button();
            this.btnMasSortNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры массива";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(199, 97);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 22);
            this.txtMax.TabIndex = 5;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(199, 60);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 22);
            this.txtMin.TabIndex = 4;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(199, 22);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 22);
            this.txtQuant.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Верхняя граница чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нижняя граница чисел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во эл. в массиве";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMas);
            this.groupBox2.Location = new System.Drawing.Point(73, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходный массив";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(17, 27);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(121, 17);
            this.lblMas.TabIndex = 3;
            this.lblMas.Text = "тут будет массив";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMasSort);
            this.groupBox3.Location = new System.Drawing.Point(73, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 55);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Преобразованный массив";
            // 
            // lblMasSort
            // 
            this.lblMasSort.AutoSize = true;
            this.lblMasSort.Location = new System.Drawing.Point(17, 25);
            this.lblMasSort.Name = "lblMasSort";
            this.lblMasSort.Size = new System.Drawing.Size(169, 17);
            this.lblMasSort.TabIndex = 4;
            this.lblMasSort.Text = "тут будет другой массив";
            // 
            // btnNewMas
            // 
            this.btnNewMas.Location = new System.Drawing.Point(73, 353);
            this.btnNewMas.Name = "btnNewMas";
            this.btnNewMas.Size = new System.Drawing.Size(176, 23);
            this.btnNewMas.TabIndex = 2;
            this.btnNewMas.Text = "Новый массив";
            this.btnNewMas.UseVisualStyleBackColor = true;
            this.btnNewMas.Click += new System.EventHandler(this.btnNewMas_Click);
            // 
            // btnMasSort
            // 
            this.btnMasSort.Enabled = false;
            this.btnMasSort.Location = new System.Drawing.Point(343, 353);
            this.btnMasSort.Name = "btnMasSort";
            this.btnMasSort.Size = new System.Drawing.Size(188, 23);
            this.btnMasSort.TabIndex = 3;
            this.btnMasSort.Text = "Сортировка";
            this.btnMasSort.UseVisualStyleBackColor = true;
            this.btnMasSort.Click += new System.EventHandler(this.btnMasSort_Click);
            // 
            // btnMasSortNew
            // 
            this.btnMasSortNew.Enabled = false;
            this.btnMasSortNew.Location = new System.Drawing.Point(188, 382);
            this.btnMasSortNew.Name = "btnMasSortNew";
            this.btnMasSortNew.Size = new System.Drawing.Size(228, 23);
            this.btnMasSortNew.TabIndex = 4;
            this.btnMasSortNew.Text = "Сортировка другим способом";
            this.btnMasSortNew.UseVisualStyleBackColor = true;
            this.btnMasSortNew.Click += new System.EventHandler(this.btnMasSortNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMasSortNew);
            this.Controls.Add(this.btnMasSort);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNewMas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "lr13";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMasSort;
        private System.Windows.Forms.Button btnNewMas;
        private System.Windows.Forms.Button btnMasSort;
        private System.Windows.Forms.Button btnMasSortNew;
    }
}

