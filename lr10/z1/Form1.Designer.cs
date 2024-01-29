namespace lr10
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лабораторнаяРаботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабораторнаяРаботаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лабораторнаяРаботаToolStripMenuItem
            // 
            this.лабораторнаяРаботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1ToolStripMenuItem,
            this.форма2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.лабораторнаяРаботаToolStripMenuItem.Name = "лабораторнаяРаботаToolStripMenuItem";
            this.лабораторнаяРаботаToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.лабораторнаяРаботаToolStripMenuItem.Text = "Лабораторная работа";
            // 
            // форма1ToolStripMenuItem
            // 
            this.форма1ToolStripMenuItem.Name = "форма1ToolStripMenuItem";
            this.форма1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.форма1ToolStripMenuItem.Text = "Форма 1";
            this.форма1ToolStripMenuItem.Click += new System.EventHandler(this.форма1ToolStripMenuItem_Click);
            // 
            // форма2ToolStripMenuItem
            // 
            this.форма2ToolStripMenuItem.Name = "форма2ToolStripMenuItem";
            this.форма2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.форма2ToolStripMenuItem.Text = "Форма 2";
            this.форма2ToolStripMenuItem.Click += new System.EventHandler(this.форма2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "lr10z1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem лабораторнаяРаботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

