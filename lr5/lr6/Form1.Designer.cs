﻿namespace lr6
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
            this.btnFack = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFack = new System.Windows.Forms.Label();
            this.txtFack = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFack
            // 
            this.btnFack.Location = new System.Drawing.Point(206, 171);
            this.btnFack.Name = "btnFack";
            this.btnFack.Size = new System.Drawing.Size(75, 23);
            this.btnFack.TabIndex = 0;
            this.btnFack.Text = "Вычислить";
            this.btnFack.UseVisualStyleBackColor = true;
            this.btnFack.Click += new System.EventHandler(this.btnFack_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(130, 102);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(76, 20);
            this.txtX.TabIndex = 1;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(108, 104);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "x=";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblFack
            // 
            this.lblFack.AutoSize = true;
            this.lblFack.Location = new System.Drawing.Point(252, 104);
            this.lblFack.Name = "lblFack";
            this.lblFack.Size = new System.Drawing.Size(21, 13);
            this.lblFack.TabIndex = 3;
            this.lblFack.Text = "x!=";
            this.lblFack.Click += new System.EventHandler(this.lblFack_Click);
            // 
            // txtFack
            // 
            this.txtFack.Location = new System.Drawing.Point(278, 102);
            this.txtFack.Name = "txtFack";
            this.txtFack.ReadOnly = true;
            this.txtFack.Size = new System.Drawing.Size(100, 20);
            this.txtFack.TabIndex = 4;
            this.txtFack.TextChanged += new System.EventHandler(this.txtFack_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(10, 11);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(56, 19);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "x^n";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(130, 126);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(76, 20);
            this.txtN.TabIndex = 6;
            this.txtN.Visible = false;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(106, 126);
            this.lblN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(19, 13);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "n=";
            this.lblN.Visible = false;
            this.lblN.Click += new System.EventHandler(this.lblN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 259);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtFack);
            this.Controls.Add(this.lblFack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnFack);
            this.Name = "Form1";
            this.Text = "lr6z1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFack;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblFack;
        private System.Windows.Forms.TextBox txtFack;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
    }
}

