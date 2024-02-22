
namespace z1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВКонецСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОкноВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.lbSentence = new System.Windows.Forms.ListBox();
            this.btnChangeStr = new System.Windows.Forms.Button();
            this.btnGenerateOn = new System.Windows.Forms.Button();
            this.lbVerbs = new System.Windows.Forms.ListBox();
            this.lbAdjectives = new System.Windows.Forms.ListBox();
            this.lbNouns = new System.Windows.Forms.ListBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите строку";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить в конец списка";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.очисткаToolStripMenuItem,
            this.скопироватьСписокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтрокуToolStripMenuItem,
            this.добавитьВКонецСпискаToolStripMenuItem,
            this.удалитьСтрокуИзСпискаToolStripMenuItem,
            this.изменитьСтрокуToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.редактированиеToolStripMenuItem.Text = "редактирование";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            this.добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            this.добавитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.добавитьСтрокуToolStripMenuItem.Text = "добавить строку";
            this.добавитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            // 
            // добавитьВКонецСпискаToolStripMenuItem
            // 
            this.добавитьВКонецСпискаToolStripMenuItem.Name = "добавитьВКонецСпискаToolStripMenuItem";
            this.добавитьВКонецСпискаToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.добавитьВКонецСпискаToolStripMenuItem.Text = "добавить в конец списка";
            this.добавитьВКонецСпискаToolStripMenuItem.Click += new System.EventHandler(this.добавитьВКонецСпискаToolStripMenuItem_Click);
            // 
            // удалитьСтрокуИзСпискаToolStripMenuItem
            // 
            this.удалитьСтрокуИзСпискаToolStripMenuItem.Name = "удалитьСтрокуИзСпискаToolStripMenuItem";
            this.удалитьСтрокуИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.удалитьСтрокуИзСпискаToolStripMenuItem.Text = "удалить строку из списка";
            this.удалитьСтрокуИзСпискаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрокуИзСпискаToolStripMenuItem_Click);
            // 
            // изменитьСтрокуToolStripMenuItem
            // 
            this.изменитьСтрокуToolStripMenuItem.Name = "изменитьСтрокуToolStripMenuItem";
            this.изменитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.изменитьСтрокуToolStripMenuItem.Text = "изменить строку";
            this.изменитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.изменитьСтрокуToolStripMenuItem_Click);
            // 
            // очисткаToolStripMenuItem
            // 
            this.очисткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьСписокToolStripMenuItem,
            this.очиститьОкноВыводаToolStripMenuItem});
            this.очисткаToolStripMenuItem.Name = "очисткаToolStripMenuItem";
            this.очисткаToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.очисткаToolStripMenuItem.Text = "очистка";
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.очиститьСписокToolStripMenuItem.Text = "очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // очиститьОкноВыводаToolStripMenuItem
            // 
            this.очиститьОкноВыводаToolStripMenuItem.Name = "очиститьОкноВыводаToolStripMenuItem";
            this.очиститьОкноВыводаToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.очиститьОкноВыводаToolStripMenuItem.Text = "очистить окно вывода";
            this.очиститьОкноВыводаToolStripMenuItem.Click += new System.EventHandler(this.очиститьОкноВыводаToolStripMenuItem_Click);
            // 
            // скопироватьСписокToolStripMenuItem
            // 
            this.скопироватьСписокToolStripMenuItem.Name = "скопироватьСписокToolStripMenuItem";
            this.скопироватьСписокToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.скопироватьСписокToolStripMenuItem.Text = "скопировать список";
            this.скопироватьСписокToolStripMenuItem.Click += new System.EventHandler(this.скопироватьСписокToolStripMenuItem_Click);
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(12, 359);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(245, 22);
            this.txtSentence.TabIndex = 3;
            // 
            // lbSentence
            // 
            this.lbSentence.FormattingEnabled = true;
            this.lbSentence.ItemHeight = 16;
            this.lbSentence.Location = new System.Drawing.Point(12, 31);
            this.lbSentence.Name = "lbSentence";
            this.lbSentence.Size = new System.Drawing.Size(245, 276);
            this.lbSentence.TabIndex = 4;
            this.lbSentence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbSentence_MouseClick);
            // 
            // btnChangeStr
            // 
            this.btnChangeStr.Location = new System.Drawing.Point(12, 445);
            this.btnChangeStr.Name = "btnChangeStr";
            this.btnChangeStr.Size = new System.Drawing.Size(198, 23);
            this.btnChangeStr.TabIndex = 5;
            this.btnChangeStr.Text = "Изменить строку";
            this.btnChangeStr.UseVisualStyleBackColor = true;
            this.btnChangeStr.Click += new System.EventHandler(this.btnChangeStr_Click);
            // 
            // btnGenerateOn
            // 
            this.btnGenerateOn.Location = new System.Drawing.Point(295, 416);
            this.btnGenerateOn.Name = "btnGenerateOn";
            this.btnGenerateOn.Size = new System.Drawing.Size(198, 23);
            this.btnGenerateOn.TabIndex = 6;
            this.btnGenerateOn.Text = "Включить генератор";
            this.btnGenerateOn.UseVisualStyleBackColor = true;
            this.btnGenerateOn.Click += new System.EventHandler(this.btnGenerateOn_Click);
            // 
            // lbVerbs
            // 
            this.lbVerbs.FormattingEnabled = true;
            this.lbVerbs.ItemHeight = 16;
            this.lbVerbs.Location = new System.Drawing.Point(295, 31);
            this.lbVerbs.Name = "lbVerbs";
            this.lbVerbs.Size = new System.Drawing.Size(198, 116);
            this.lbVerbs.TabIndex = 7;
            this.lbVerbs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbVerbs_MouseClick);
            // 
            // lbAdjectives
            // 
            this.lbAdjectives.FormattingEnabled = true;
            this.lbAdjectives.ItemHeight = 16;
            this.lbAdjectives.Location = new System.Drawing.Point(295, 153);
            this.lbAdjectives.Name = "lbAdjectives";
            this.lbAdjectives.Size = new System.Drawing.Size(198, 116);
            this.lbAdjectives.TabIndex = 8;
            this.lbAdjectives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAdjectives_MouseClick);
            // 
            // lbNouns
            // 
            this.lbNouns.FormattingEnabled = true;
            this.lbNouns.ItemHeight = 16;
            this.lbNouns.Location = new System.Drawing.Point(295, 275);
            this.lbNouns.Name = "lbNouns";
            this.lbNouns.Size = new System.Drawing.Size(198, 116);
            this.lbNouns.TabIndex = 9;
            this.lbNouns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbNouns_MouseClick);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(12, 416);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(198, 23);
            this.btnClearInput.TabIndex = 10;
            this.btnClearInput.Text = "Очистить строку ввода";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 475);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.lbNouns);
            this.Controls.Add(this.lbAdjectives);
            this.Controls.Add(this.lbVerbs);
            this.Controls.Add(this.btnGenerateOn);
            this.Controls.Add(this.btnChangeStr);
            this.Controls.Add(this.lbSentence);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "z1";
            this.Text = "lr25z1";
            this.Load += new System.EventHandler(this.z1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВКонецСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуИзСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьОкноВыводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьСписокToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.ListBox lbSentence;
        private System.Windows.Forms.Button btnChangeStr;
        private System.Windows.Forms.Button btnGenerateOn;
        private System.Windows.Forms.ListBox lbVerbs;
        private System.Windows.Forms.ListBox lbAdjectives;
        private System.Windows.Forms.ListBox lbNouns;
        private System.Windows.Forms.Button btnClearInput;
    }
}

