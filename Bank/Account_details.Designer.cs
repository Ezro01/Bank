namespace Bank
{
    partial class Account_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_details));
            this.bank_ultimate_versionDataSet = new Bank.Bank_ultimate_versionDataSet();
            this.реквизиты_счётаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реквизиты_счётаTableAdapter = new Bank.Bank_ultimate_versionDataSetTableAdapters.Реквизиты_счётаTableAdapter();
            this.tableAdapterManager = new Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager();
            this.реквизиты_счётаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.реквизиты_счётаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.реквизиты_счётаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаBindingNavigator)).BeginInit();
            this.реквизиты_счётаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_ultimate_versionDataSet
            // 
            this.bank_ultimate_versionDataSet.DataSetName = "Bank_ultimate_versionDataSet";
            this.bank_ultimate_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // реквизиты_счётаBindingSource
            // 
            this.реквизиты_счётаBindingSource.DataMember = "Реквизиты_счёта";
            this.реквизиты_счётаBindingSource.DataSource = this.bank_ultimate_versionDataSet;
            // 
            // реквизиты_счётаTableAdapter
            // 
            this.реквизиты_счётаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заявление_на_оформление_картыTableAdapter = null;
            this.tableAdapterManager.КартаTableAdapter = null;
            this.tableAdapterManager.ПаспортTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Реквизиты_счётаTableAdapter = this.реквизиты_счётаTableAdapter;
            this.tableAdapterManager.Сотрудники_банкаTableAdapter = null;
            this.tableAdapterManager.Типы_картTableAdapter = null;
            // 
            // реквизиты_счётаBindingNavigator
            // 
            this.реквизиты_счётаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.реквизиты_счётаBindingNavigator.BindingSource = this.реквизиты_счётаBindingSource;
            this.реквизиты_счётаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.реквизиты_счётаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.реквизиты_счётаBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.реквизиты_счётаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.реквизиты_счётаBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.реквизиты_счётаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.реквизиты_счётаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.реквизиты_счётаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.реквизиты_счётаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.реквизиты_счётаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.реквизиты_счётаBindingNavigator.Name = "реквизиты_счётаBindingNavigator";
            this.реквизиты_счётаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.реквизиты_счётаBindingNavigator.Size = new System.Drawing.Size(1413, 42);
            this.реквизиты_счётаBindingNavigator.TabIndex = 0;
            this.реквизиты_счётаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 94);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 94);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 100);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(86, 94);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 94);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 94);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 100);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 94);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // реквизиты_счётаBindingNavigatorSaveItem
            // 
            this.реквизиты_счётаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.реквизиты_счётаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("реквизиты_счётаBindingNavigatorSaveItem.Image")));
            this.реквизиты_счётаBindingNavigatorSaveItem.Name = "реквизиты_счётаBindingNavigatorSaveItem";
            this.реквизиты_счётаBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 94);
            this.реквизиты_счётаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.реквизиты_счётаBindingNavigatorSaveItem.Click += new System.EventHandler(this.реквизиты_счётаBindingNavigatorSaveItem_Click);
            // 
            // реквизиты_счётаDataGridView
            // 
            this.реквизиты_счётаDataGridView.AutoGenerateColumns = false;
            this.реквизиты_счётаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.реквизиты_счётаDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.реквизиты_счётаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.реквизиты_счётаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.реквизиты_счётаDataGridView.DataSource = this.реквизиты_счётаBindingSource;
            this.реквизиты_счётаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.реквизиты_счётаDataGridView.Location = new System.Drawing.Point(0, 42);
            this.реквизиты_счётаDataGridView.Name = "реквизиты_счётаDataGridView";
            this.реквизиты_счётаDataGridView.RowHeadersWidth = 82;
            this.реквизиты_счётаDataGridView.RowTemplate.Height = 33;
            this.реквизиты_счётаDataGridView.Size = new System.Drawing.Size(1413, 967);
            this.реквизиты_счётаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_счёта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_счёта";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Пользователя";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Пользователя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Корр_счёт";
            this.dataGridViewTextBoxColumn3.HeaderText = "Корр_счёт";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "БИК";
            this.dataGridViewTextBoxColumn4.HeaderText = "БИК";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 100);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(200, 100);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(86, 36);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(1008, 24);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(119, 29);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // Account_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 1009);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.реквизиты_счётаDataGridView);
            this.Controls.Add(this.реквизиты_счётаBindingNavigator);
            this.Name = "Account_details";
            this.Text = "Реквичиты счёта";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Account_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаBindingNavigator)).EndInit();
            this.реквизиты_счётаBindingNavigator.ResumeLayout(false);
            this.реквизиты_счётаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реквизиты_счётаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bank_ultimate_versionDataSet bank_ultimate_versionDataSet;
        private System.Windows.Forms.BindingSource реквизиты_счётаBindingSource;
        private Bank_ultimate_versionDataSetTableAdapters.Реквизиты_счётаTableAdapter реквизиты_счётаTableAdapter;
        private Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator реквизиты_счётаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton реквизиты_счётаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView реквизиты_счётаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
    }
}