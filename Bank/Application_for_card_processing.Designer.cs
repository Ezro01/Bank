namespace Bank
{
    partial class Application_for_card_processing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_for_card_processing));
            this.bank_ultimate_versionDataSet = new Bank.Bank_ultimate_versionDataSet();
            this.заявление_на_оформление_картыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявление_на_оформление_картыTableAdapter = new Bank.Bank_ultimate_versionDataSetTableAdapters.Заявление_на_оформление_картыTableAdapter();
            this.tableAdapterManager = new Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager();
            this.заявление_на_оформление_картыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заявление_на_оформление_картыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.заявление_на_оформление_картыDataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыBindingNavigator)).BeginInit();
            this.заявление_на_оформление_картыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_ultimate_versionDataSet
            // 
            this.bank_ultimate_versionDataSet.DataSetName = "Bank_ultimate_versionDataSet";
            this.bank_ultimate_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявление_на_оформление_картыBindingSource
            // 
            this.заявление_на_оформление_картыBindingSource.DataMember = "Заявление_на_оформление_карты";
            this.заявление_на_оформление_картыBindingSource.DataSource = this.bank_ultimate_versionDataSet;
            // 
            // заявление_на_оформление_картыTableAdapter
            // 
            this.заявление_на_оформление_картыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заявление_на_оформление_картыTableAdapter = this.заявление_на_оформление_картыTableAdapter;
            this.tableAdapterManager.КартаTableAdapter = null;
            this.tableAdapterManager.ПаспортTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Реквизиты_счётаTableAdapter = null;
            this.tableAdapterManager.Сотрудники_банкаTableAdapter = null;
            this.tableAdapterManager.Типы_картTableAdapter = null;
            // 
            // заявление_на_оформление_картыBindingNavigator
            // 
            this.заявление_на_оформление_картыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявление_на_оформление_картыBindingNavigator.BindingSource = this.заявление_на_оформление_картыBindingSource;
            this.заявление_на_оформление_картыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявление_на_оформление_картыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявление_на_оформление_картыBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.заявление_на_оформление_картыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заявление_на_оформление_картыBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.заявление_на_оформление_картыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявление_на_оформление_картыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявление_на_оформление_картыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявление_на_оформление_картыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявление_на_оформление_картыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявление_на_оформление_картыBindingNavigator.Name = "заявление_на_оформление_картыBindingNavigator";
            this.заявление_на_оформление_картыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявление_на_оформление_картыBindingNavigator.Size = new System.Drawing.Size(2350, 42);
            this.заявление_на_оформление_картыBindingNavigator.TabIndex = 0;
            this.заявление_на_оформление_картыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(86, 36);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // заявление_на_оформление_картыBindingNavigatorSaveItem
            // 
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявление_на_оформление_картыBindingNavigatorSaveItem.Image")));
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.Name = "заявление_на_оформление_картыBindingNavigatorSaveItem";
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заявление_на_оформление_картыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявление_на_оформление_картыBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(200, 42);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(86, 36);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // заявление_на_оформление_картыDataGridView
            // 
            this.заявление_на_оформление_картыDataGridView.AutoGenerateColumns = false;
            this.заявление_на_оформление_картыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.заявление_на_оформление_картыDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.заявление_на_оформление_картыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявление_на_оформление_картыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.заявление_на_оформление_картыDataGridView.DataSource = this.заявление_на_оформление_картыBindingSource;
            this.заявление_на_оформление_картыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.заявление_на_оформление_картыDataGridView.Location = new System.Drawing.Point(0, 42);
            this.заявление_на_оформление_картыDataGridView.Name = "заявление_на_оформление_картыDataGridView";
            this.заявление_на_оформление_картыDataGridView.RowHeadersWidth = 82;
            this.заявление_на_оформление_картыDataGridView.RowTemplate.Height = 33;
            this.заявление_на_оформление_картыDataGridView.Size = new System.Drawing.Size(2350, 1499);
            this.заявление_на_оформление_картыDataGridView.TabIndex = 1;
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(1016, 24);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(119, 29);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_заявления";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_заявления";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_счёта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_счёта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_подачи_заявления";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_подачи_заявления";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Статус_заявки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус_заявки";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "Принята",
            "На рассмотрении",
            "Одобрена",
            "Ожидает выдачи карты",
            "Карта выдана",
            "Отклонена",
            "Отменена пользователем"});
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Application_for_card_processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2350, 1541);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.заявление_на_оформление_картыDataGridView);
            this.Controls.Add(this.заявление_на_оформление_картыBindingNavigator);
            this.Name = "Application_for_card_processing";
            this.Text = "Заявление на оформление карты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Application_for_card_processing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыBindingNavigator)).EndInit();
            this.заявление_на_оформление_картыBindingNavigator.ResumeLayout(false);
            this.заявление_на_оформление_картыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявление_на_оформление_картыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bank_ultimate_versionDataSet bank_ultimate_versionDataSet;
        private System.Windows.Forms.BindingSource заявление_на_оформление_картыBindingSource;
        private Bank_ultimate_versionDataSetTableAdapters.Заявление_на_оформление_картыTableAdapter заявление_на_оформление_картыTableAdapter;
        private Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявление_на_оформление_картыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заявление_на_оформление_картыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView заявление_на_оформление_картыDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}