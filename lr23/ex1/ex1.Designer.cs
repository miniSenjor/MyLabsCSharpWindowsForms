
namespace ex1
{
    partial class ex1
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
            this.btnArea = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBSquare = new System.Windows.Forms.CheckBox();
            this.cBIsosceles = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(126, 91);
            this.btnArea.Margin = new System.Windows.Forms.Padding(2);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(62, 19);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Площадь";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(163, 160);
            this.btnName.Margin = new System.Windows.Forms.Padding(2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(56, 19);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "Имя";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(291, 113);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ширина";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(291, 49);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(76, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(291, 73);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(76, 20);
            this.txtWidth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Площадь";
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Checked = true;
            this.rbTriangle.Location = new System.Drawing.Point(432, 56);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(90, 17);
            this.rbTriangle.TabIndex = 8;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Треугольник";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(432, 79);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(105, 17);
            this.rbRectangle.TabIndex = 9;
            this.rbRectangle.Text = "Прямоугольник";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBSquare);
            this.groupBox1.Controls.Add(this.cBIsosceles);
            this.groupBox1.Location = new System.Drawing.Point(366, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип фигуры";
            // 
            // cBSquare
            // 
            this.cBSquare.AutoSize = true;
            this.cBSquare.Location = new System.Drawing.Point(6, 42);
            this.cBSquare.Name = "cBSquare";
            this.cBSquare.Size = new System.Drawing.Size(68, 17);
            this.cBSquare.TabIndex = 1;
            this.cBSquare.Text = "Квадрат";
            this.cBSquare.UseVisualStyleBackColor = true;
            this.cBSquare.Visible = false;
            // 
            // cBIsosceles
            // 
            this.cBIsosceles.AutoSize = true;
            this.cBIsosceles.Location = new System.Drawing.Point(6, 19);
            this.cBIsosceles.Name = "cBIsosceles";
            this.cBIsosceles.Size = new System.Drawing.Size(113, 17);
            this.cBIsosceles.TabIndex = 0;
            this.cBIsosceles.Text = "Равнобедренный";
            this.cBIsosceles.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 160);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 11;
            // 
            // ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbRectangle);
            this.Controls.Add(this.rbTriangle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ex1";
            this.Text = "lr23ex1";
            this.Load += new System.EventHandler(this.ex1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBIsosceles;
        private System.Windows.Forms.CheckBox cBSquare;
        private System.Windows.Forms.TextBox txtName;
    }
}

