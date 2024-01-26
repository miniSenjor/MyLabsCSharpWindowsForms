namespace lr12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияРаботыСМассивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияРаботыСФункциямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.демонстрацияРаботыСМассивамиToolStripMenuItem,
            this.демонстрацияРаботыСФункциямиToolStripMenuItem,
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem});
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.темыToolStripMenuItem.Text = "Темы";
            // 
            // демонстрацияРаботыСМассивамиToolStripMenuItem
            // 
            this.демонстрацияРаботыСМассивамиToolStripMenuItem.Name = "демонстрацияРаботыСМассивамиToolStripMenuItem";
            this.демонстрацияРаботыСМассивамиToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.демонстрацияРаботыСМассивамиToolStripMenuItem.Text = "Демонстрация работы с массивами";
            this.демонстрацияРаботыСМассивамиToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияРаботыСМассивамиToolStripMenuItem_Click);
            // 
            // демонстрацияРаботыСФункциямиToolStripMenuItem
            // 
            this.демонстрацияРаботыСФункциямиToolStripMenuItem.Name = "демонстрацияРаботыСФункциямиToolStripMenuItem";
            this.демонстрацияРаботыСФункциямиToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.демонстрацияРаботыСФункциямиToolStripMenuItem.Text = "Демонстрация работы с функциями";
            this.демонстрацияРаботыСФункциямиToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияРаботыСФункциямиToolStripMenuItem_Click);
            // 
            // демонстрацияРаботыСоСтрокамиToolStripMenuItem
            // 
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem.Name = "демонстрацияРаботыСоСтрокамиToolStripMenuItem";
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem.Text = "Демонстрация работы со строками";
            this.демонстрацияРаботыСоСтрокамиToolStripMenuItem.Click += new System.EventHandler(this.демонстрацияРаботыСоСтрокамиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "lr12";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияРаботыСМассивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияРаботыСФункциямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem демонстрацияРаботыСоСтрокамиToolStripMenuItem;
    }
}

