namespace lr6
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
            this.btnFack.Location = new System.Drawing.Point(275, 211);
            this.btnFack.Margin = new System.Windows.Forms.Padding(4);
            this.btnFack.Name = "btnFack";
            this.btnFack.Size = new System.Drawing.Size(100, 28);
            this.btnFack.TabIndex = 0;
            this.btnFack.Text = "Вычислить";
            this.btnFack.UseVisualStyleBackColor = true;
            this.btnFack.Click += new System.EventHandler(this.btnFack_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(174, 125);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(144, 128);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "x=";
            // 
            // lblFack
            // 
            this.lblFack.AutoSize = true;
            this.lblFack.Location = new System.Drawing.Point(336, 128);
            this.lblFack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFack.Name = "lblFack";
            this.lblFack.Size = new System.Drawing.Size(25, 17);
            this.lblFack.TabIndex = 3;
            this.lblFack.Text = "x!=";
            // 
            // txtFack
            // 
            this.txtFack.Location = new System.Drawing.Point(371, 125);
            this.txtFack.Margin = new System.Windows.Forms.Padding(4);
            this.txtFack.Name = "txtFack";
            this.txtFack.ReadOnly = true;
            this.txtFack.Size = new System.Drawing.Size(132, 22);
            this.txtFack.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(13, 13);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "x^n";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(174, 155);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 6;
            this.txtN.Visible = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(142, 155);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(24, 17);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "n=";
            this.lblN.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 319);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtFack);
            this.Controls.Add(this.lblFack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnFack);
            this.Margin = new System.Windows.Forms.Padding(4);
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

