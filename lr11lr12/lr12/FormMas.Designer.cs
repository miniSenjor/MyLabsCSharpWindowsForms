
namespace lr12
{
    partial class FormMas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblQuantOdd = new System.Windows.Forms.Label();
            this.lblQuantEven = new System.Windows.Forms.Label();
            this.btnCreateMas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasRev = new System.Windows.Forms.TextBox();
            this.txtMasEven = new System.Windows.Forms.TextBox();
            this.txtMasOdd = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblQuantOdd);
            this.Panel1.Controls.Add(this.lblQuantEven);
            this.Panel1.Controls.Add(this.btnCreateMas);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.txtN);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.txtMas);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.txtMasRev);
            this.Panel1.Controls.Add(this.txtMasEven);
            this.Panel1.Controls.Add(this.txtMasOdd);
            this.Panel1.Location = new System.Drawing.Point(21, 26);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(592, 249);
            this.Panel1.TabIndex = 13;
            // 
            // lblQuantOdd
            // 
            this.lblQuantOdd.AutoSize = true;
            this.lblQuantOdd.Location = new System.Drawing.Point(322, 140);
            this.lblQuantOdd.Name = "lblQuantOdd";
            this.lblQuantOdd.Size = new System.Drawing.Size(55, 17);
            this.lblQuantOdd.TabIndex = 13;
            this.lblQuantOdd.Text = "кол-во:";
            // 
            // lblQuantEven
            // 
            this.lblQuantEven.AutoSize = true;
            this.lblQuantEven.Location = new System.Drawing.Point(322, 172);
            this.lblQuantEven.Name = "lblQuantEven";
            this.lblQuantEven.Size = new System.Drawing.Size(55, 17);
            this.lblQuantEven.TabIndex = 12;
            this.lblQuantEven.Text = "кол-во:";
            // 
            // btnCreateMas
            // 
            this.btnCreateMas.Location = new System.Drawing.Point(447, 95);
            this.btnCreateMas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateMas.Name = "btnCreateMas";
            this.btnCreateMas.Size = new System.Drawing.Size(100, 43);
            this.btnCreateMas.TabIndex = 3;
            this.btnCreateMas.Text = "Создать массив";
            this.btnCreateMas.UseVisualStyleBackColor = true;
            this.btnCreateMas.Click += new System.EventHandler(this.btnCreateMas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Четные элементы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во элементов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Нечетные элементы";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(183, 43);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(132, 22);
            this.txtN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Обратный массив";
            // 
            // txtMas
            // 
            this.txtMas.Location = new System.Drawing.Point(183, 73);
            this.txtMas.Margin = new System.Windows.Forms.Padding(4);
            this.txtMas.Multiline = true;
            this.txtMas.Name = "txtMas";
            this.txtMas.Size = new System.Drawing.Size(132, 24);
            this.txtMas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Массив";
            // 
            // txtMasRev
            // 
            this.txtMasRev.Location = new System.Drawing.Point(183, 105);
            this.txtMasRev.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasRev.Multiline = true;
            this.txtMasRev.Name = "txtMasRev";
            this.txtMasRev.Size = new System.Drawing.Size(132, 24);
            this.txtMasRev.TabIndex = 5;
            // 
            // txtMasEven
            // 
            this.txtMasEven.Location = new System.Drawing.Point(183, 169);
            this.txtMasEven.Name = "txtMasEven";
            this.txtMasEven.Size = new System.Drawing.Size(132, 22);
            this.txtMasEven.TabIndex = 7;
            // 
            // txtMasOdd
            // 
            this.txtMasOdd.Location = new System.Drawing.Point(183, 137);
            this.txtMasOdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasOdd.Multiline = true;
            this.txtMasOdd.Name = "txtMasOdd";
            this.txtMasOdd.Size = new System.Drawing.Size(132, 24);
            this.txtMasOdd.TabIndex = 6;
            // 
            // FormMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 309);
            this.Controls.Add(this.Panel1);
            this.Name = "FormMas";
            this.Text = "FormMas";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lblQuantOdd;
        private System.Windows.Forms.Label lblQuantEven;
        private System.Windows.Forms.Button btnCreateMas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasRev;
        private System.Windows.Forms.TextBox txtMasEven;
        private System.Windows.Forms.TextBox txtMasOdd;
    }
}