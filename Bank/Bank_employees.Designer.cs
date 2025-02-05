namespace Bank
{
    partial class Bank_employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank_employees));
            this.bank_ultimate_versionDataSet = new Bank.Bank_ultimate_versionDataSet();
            this.сотрудники_банкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудники_банкаTableAdapter = new Bank.Bank_ultimate_versionDataSetTableAdapters.Сотрудники_банкаTableAdapter();
            this.tableAdapterManager = new Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager();
            this.сотрудники_банкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сотрудники_банкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.сотрудники_банкаDataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаBindingNavigator)).BeginInit();
            this.сотрудники_банкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_ultimate_versionDataSet
            // 
            this.bank_ultimate_versionDataSet.DataSetName = "Bank_ultimate_versionDataSet";
            this.bank_ultimate_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудники_банкаBindingSource
            // 
            this.сотрудники_банкаBindingSource.DataMember = "Сотрудники_банка";
            this.сотрудники_банкаBindingSource.DataSource = this.bank_ultimate_versionDataSet;
            // 
            // сотрудники_банкаTableAdapter
            // 
            this.сотрудники_банкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заявление_на_оформление_картыTableAdapter = null;
            this.tableAdapterManager.КартаTableAdapter = null;
            this.tableAdapterManager.ПаспортTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Реквизиты_счётаTableAdapter = null;
            this.tableAdapterManager.Сотрудники_банкаTableAdapter = this.сотрудники_банкаTableAdapter;
            this.tableAdapterManager.Типы_картTableAdapter = null;
            // 
            // сотрудники_банкаBindingNavigator
            // 
            this.сотрудники_банкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудники_банкаBindingNavigator.BindingSource = this.сотрудники_банкаBindingSource;
            this.сотрудники_банкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудники_банкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудники_банкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.сотрудники_банкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сотрудники_банкаBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.сотрудники_банкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудники_банкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудники_банкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудники_банкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудники_банкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудники_банкаBindingNavigator.Name = "сотрудники_банкаBindingNavigator";
            this.сотрудники_банкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудники_банкаBindingNavigator.Size = new System.Drawing.Size(1849, 42);
            this.сотрудники_банкаBindingNavigator.TabIndex = 0;
            this.сотрудники_банкаBindingNavigator.Text = "bindingNavigator1";
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
            // сотрудники_банкаBindingNavigatorSaveItem
            // 
            this.сотрудники_банкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудники_банкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудники_банкаBindingNavigatorSaveItem.Image")));
            this.сотрудники_банкаBindingNavigatorSaveItem.Name = "сотрудники_банкаBindingNavigatorSaveItem";
            this.сотрудники_банкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.сотрудники_банкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудники_банкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудники_банкаBindingNavigatorSaveItem_Click);
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
            // сотрудники_банкаDataGridView
            // 
            this.сотрудники_банкаDataGridView.AutoGenerateColumns = false;
            this.сотрудники_банкаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.сотрудники_банкаDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.сотрудники_банкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудники_банкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.сотрудники_банкаDataGridView.DataSource = this.сотрудники_банкаBindingSource;
            this.сотрудники_банкаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сотрудники_банкаDataGridView.Location = new System.Drawing.Point(0, 42);
            this.сотрудники_банкаDataGridView.Name = "сотрудники_банкаDataGridView";
            this.сотрудники_банкаDataGridView.RowHeadersWidth = 82;
            this.сотрудники_банкаDataGridView.RowTemplate.Height = 33;
            this.сотрудники_банкаDataGridView.Size = new System.Drawing.Size(1849, 714);
            this.сотрудники_банкаDataGridView.TabIndex = 1;
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(1024, 24);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(119, 29);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "Менеджер по работе с клиентами"});
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Bank_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 756);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.сотрудники_банкаDataGridView);
            this.Controls.Add(this.сотрудники_банкаBindingNavigator);
            this.Name = "Bank_employees";
            this.Text = "Сотрудники банка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bank_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаBindingNavigator)).EndInit();
            this.сотрудники_банкаBindingNavigator.ResumeLayout(false);
            this.сотрудники_банкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_банкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bank_ultimate_versionDataSet bank_ultimate_versionDataSet;
        private System.Windows.Forms.BindingSource сотрудники_банкаBindingSource;
        private Bank_ultimate_versionDataSetTableAdapters.Сотрудники_банкаTableAdapter сотрудники_банкаTableAdapter;
        private Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудники_банкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сотрудники_банкаBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.DataGridView сотрудники_банкаDataGridView;
        private System.Windows.Forms.CheckBox checkBoxFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}