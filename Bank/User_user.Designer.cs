namespace Bank
{
    partial class User_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_user));
            this.bank_ultimate_versionDataSet = new Bank.Bank_ultimate_versionDataSet();
            this.vw_Пользователь_ПрофильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Пользователь_ПрофильTableAdapter = new Bank.Bank_ultimate_versionDataSetTableAdapters.vw_Пользователь_ПрофильTableAdapter();
            this.tableAdapterManager = new Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager();
            this.vw_Пользователь_ПрофильBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vw_Пользователь_ПрофильDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильBindingNavigator)).BeginInit();
            this.vw_Пользователь_ПрофильBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_ultimate_versionDataSet
            // 
            this.bank_ultimate_versionDataSet.DataSetName = "Bank_ultimate_versionDataSet";
            this.bank_ultimate_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_Пользователь_ПрофильBindingSource
            // 
            this.vw_Пользователь_ПрофильBindingSource.DataMember = "vw_Пользователь_Профиль";
            this.vw_Пользователь_ПрофильBindingSource.DataSource = this.bank_ultimate_versionDataSet;
            // 
            // vw_Пользователь_ПрофильTableAdapter
            // 
            this.vw_Пользователь_ПрофильTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Bank.Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Заявление_на_оформление_картыTableAdapter = null;
            this.tableAdapterManager.КартаTableAdapter = null;
            this.tableAdapterManager.ПаспортTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Реквизиты_счётаTableAdapter = null;
            this.tableAdapterManager.Сотрудники_банкаTableAdapter = null;
            this.tableAdapterManager.Типы_картTableAdapter = null;
            // 
            // vw_Пользователь_ПрофильBindingNavigator
            // 
            this.vw_Пользователь_ПрофильBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vw_Пользователь_ПрофильBindingNavigator.BindingSource = this.vw_Пользователь_ПрофильBindingSource;
            this.vw_Пользователь_ПрофильBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vw_Пользователь_ПрофильBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vw_Пользователь_ПрофильBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.vw_Пользователь_ПрофильBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem});
            this.vw_Пользователь_ПрофильBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vw_Пользователь_ПрофильBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vw_Пользователь_ПрофильBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vw_Пользователь_ПрофильBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vw_Пользователь_ПрофильBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vw_Пользователь_ПрофильBindingNavigator.Name = "vw_Пользователь_ПрофильBindingNavigator";
            this.vw_Пользователь_ПрофильBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vw_Пользователь_ПрофильBindingNavigator.Size = new System.Drawing.Size(2513, 42);
            this.vw_Пользователь_ПрофильBindingNavigator.TabIndex = 0;
            this.vw_Пользователь_ПрофильBindingNavigator.Text = "bindingNavigator1";
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
            // vw_Пользователь_ПрофильBindingNavigatorSaveItem
            // 
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.Enabled = false;
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vw_Пользователь_ПрофильBindingNavigatorSaveItem.Image")));
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.Name = "vw_Пользователь_ПрофильBindingNavigatorSaveItem";
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.vw_Пользователь_ПрофильBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // vw_Пользователь_ПрофильDataGridView
            // 
            this.vw_Пользователь_ПрофильDataGridView.AutoGenerateColumns = false;
            this.vw_Пользователь_ПрофильDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vw_Пользователь_ПрофильDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.vw_Пользователь_ПрофильDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_Пользователь_ПрофильDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vw_Пользователь_ПрофильDataGridView.DataSource = this.vw_Пользователь_ПрофильBindingSource;
            this.vw_Пользователь_ПрофильDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vw_Пользователь_ПрофильDataGridView.Location = new System.Drawing.Point(0, 42);
            this.vw_Пользователь_ПрофильDataGridView.Name = "vw_Пользователь_ПрофильDataGridView";
            this.vw_Пользователь_ПрофильDataGridView.ReadOnly = true;
            this.vw_Пользователь_ПрофильDataGridView.RowHeadersWidth = 82;
            this.vw_Пользователь_ПрофильDataGridView.RowTemplate.Height = 33;
            this.vw_Пользователь_ПрофильDataGridView.Size = new System.Drawing.Size(2513, 1833);
            this.vw_Пользователь_ПрофильDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Текущий_Паспорт";
            this.dataGridViewTextBoxColumn2.HeaderText = "Текущий_Паспорт";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_телефона";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_телефона";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Почта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // User_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2513, 1875);
            this.Controls.Add(this.vw_Пользователь_ПрофильDataGridView);
            this.Controls.Add(this.vw_Пользователь_ПрофильBindingNavigator);
            this.Name = "User_user";
            this.Text = "Пользователь";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_ultimate_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильBindingNavigator)).EndInit();
            this.vw_Пользователь_ПрофильBindingNavigator.ResumeLayout(false);
            this.vw_Пользователь_ПрофильBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Пользователь_ПрофильDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bank_ultimate_versionDataSet bank_ultimate_versionDataSet;
        private System.Windows.Forms.BindingSource vw_Пользователь_ПрофильBindingSource;
        private Bank_ultimate_versionDataSetTableAdapters.vw_Пользователь_ПрофильTableAdapter vw_Пользователь_ПрофильTableAdapter;
        private Bank_ultimate_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vw_Пользователь_ПрофильBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vw_Пользователь_ПрофильBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vw_Пользователь_ПрофильDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}