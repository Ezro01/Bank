namespace Bank
{
    partial class Main
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
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реквизитыСчётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявлениеНаОформлениеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыКартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.паспортToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.реквизитыСчётаToolStripMenuItem,
            this.заявлениеНаОформлениеКартыToolStripMenuItem,
            this.картаToolStripMenuItem,
            this.типыКартToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(131, 38);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // паспортToolStripMenuItem
            // 
            this.паспортToolStripMenuItem.Name = "паспортToolStripMenuItem";
            this.паспортToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.паспортToolStripMenuItem.Text = "Паспорт";
            this.паспортToolStripMenuItem.Click += new System.EventHandler(this.паспортToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.пользовательToolStripMenuItem_Click);
            // 
            // реквизитыСчётаToolStripMenuItem
            // 
            this.реквизитыСчётаToolStripMenuItem.Name = "реквизитыСчётаToolStripMenuItem";
            this.реквизитыСчётаToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.реквизитыСчётаToolStripMenuItem.Text = "Реквизиты счёта";
            this.реквизитыСчётаToolStripMenuItem.Click += new System.EventHandler(this.реквизитыСчётаToolStripMenuItem_Click);
            // 
            // заявлениеНаОформлениеКартыToolStripMenuItem
            // 
            this.заявлениеНаОформлениеКартыToolStripMenuItem.Name = "заявлениеНаОформлениеКартыToolStripMenuItem";
            this.заявлениеНаОформлениеКартыToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.заявлениеНаОформлениеКартыToolStripMenuItem.Text = "Заявление на оформление карты";
            this.заявлениеНаОформлениеКартыToolStripMenuItem.Click += new System.EventHandler(this.заявлениеНаОформлениеКартыToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.картаToolStripMenuItem.Text = "Карта";
            this.картаToolStripMenuItem.Click += new System.EventHandler(this.картаToolStripMenuItem_Click);
            // 
            // типыКартToolStripMenuItem
            // 
            this.типыКартToolStripMenuItem.Name = "типыКартToolStripMenuItem";
            this.типыКартToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.типыКартToolStripMenuItem.Text = "Типы карт";
            this.типыКартToolStripMenuItem.Click += new System.EventHandler(this.типыКартToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(518, 44);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники банка";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            this.разработчикToolStripMenuItem.Click += new System.EventHandler(this.разработчикToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 759);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реквизитыСчётаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявлениеНаОформлениеКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыКартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

