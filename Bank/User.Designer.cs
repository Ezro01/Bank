namespace Bank
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.bank_ultimate_versionDataSet = new Bank.Bank_ultimate_versionDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new Bank.Bank_ultimate_versionDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager();
            this.пользовательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.пользовательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.пользовательDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).BeginInit();
            this.пользовательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_ultimate_versionDataSet
            // 
            this.bank_ultimate_versionDataSet.DataSetName = "Bank_ultimate_versionDataSet";
            this.bank_ultimate_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.bank_ultimate_versionDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заявление_на_оформление_картыTableAdapter = null;
            this.tableAdapterManager.КартаTableAdapter = null;
            this.tableAdapterManager.ПаспортTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.Реквизиты_счётаTableAdapter = null;
            this.tableAdapterManager.Сотрудники_банкаTableAdapter = null;
            this.tableAdapterManager.Типы_картTableAdapter = null;
            // 
            // пользовательBindingNavigator
            // 
            this.пользовательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пользовательBindingNavigator.BindingSource = this.пользовательBindingSource;
            this.пользовательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пользовательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пользовательBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.пользовательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.пользовательBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.пользовательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пользовательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пользовательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пользовательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пользовательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пользовательBindingNavigator.Name = "пользовательBindingNavigator";
            this.пользовательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пользовательBindingNavigator.Size = new System.Drawing.Size(2153, 50);
            this.пользовательBindingNavigator.TabIndex = 0;
            this.пользовательBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(86, 44);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // пользовательBindingNavigatorSaveItem
            // 
            this.пользовательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пользовательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательBindingNavigatorSaveItem.Image")));
            this.пользовательBindingNavigatorSaveItem.Name = "пользовательBindingNavigatorSaveItem";
            this.пользовательBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.пользовательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пользовательBindingNavigatorSaveItem.Click += new System.EventHandler(this.пользовательBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(200, 50);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(86, 44);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // пользовательDataGridView
            // 
            this.пользовательDataGridView.AutoGenerateColumns = false;
            this.пользовательDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.пользовательDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.пользовательDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользовательDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.пользовательDataGridView.DataSource = this.пользовательBindingSource;
            this.пользовательDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.пользовательDataGridView.Location = new System.Drawing.Point(0, 50);
            this.пользовательDataGridView.Name = "пользовательDataGridView";
            this.пользовательDataGridView.RowHeadersWidth = 82;
            this.пользовательDataGridView.RowTemplate.Height = 33;
            this.пользовательDataGridView.Size = new System.Drawing.Size(2153, 1221);
            this.пользовательDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Пользователя";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Пользователя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_телефона";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_телефона";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Почта";
            this.dataGridViewTextBoxColumn3.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(1000, 24);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(119, 29);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2153, 1271);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.пользовательDataGridView);
            this.Controls.Add(this.пользовательBindingNavigator);
            this.Name = "User";
            this.Text = "Пользователь";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).EndInit();
            this.пользовательBindingNavigator.ResumeLayout(false);
            this.пользовательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bank_ultimate_versionDataSet bank_ultimate_versionDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private Bank_ultimate_versionDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользовательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пользовательBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView пользовательDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
    }
}