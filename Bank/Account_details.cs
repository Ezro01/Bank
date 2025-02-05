﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Account_details : Form
    {
        public Account_details()
        {
            InitializeComponent();
            if (UserSession.Role == "Role_User")
            {
                // Блокируем кнопку сохранения для пользователей с ролью Role_User
                реквизиты_счётаBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                toolStripTextBoxFind.Enabled = false;
                toolStripButtonFind.Enabled = false;
                checkBoxFind.Enabled = false;
                реквизиты_счётаDataGridView.ReadOnly = true;
            }
        }

        private void реквизиты_счётаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.реквизиты_счётаBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM  Реквизиты_счёта"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)account_detailsBindingSource.DataSource;
                    dataAdapter.Update(dataTable); // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Account_details_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);

        }

        private static Account_details ad;
        public static Account_details account_details
        {
            get
            {
                if (ad == null || ad.IsDisposed) ad = new Account_details();
                return ad;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource account_detailsBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Реквизиты_счёта";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    account_detailsBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    реквизиты_счётаDataGridView.DataSource = account_detailsBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    реквизиты_счётаBindingNavigator.BindingSource = account_detailsBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int indexPos;
            string fieldName = GetSelectedFieldName(); // Получаем имя поля, по которому будем искать

            if (string.IsNullOrEmpty(fieldName))
            {
                MessageBox.Show("Выберите столбец для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Проверка, существует ли это поле в source
                if (!(account_detailsBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = account_detailsBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                account_detailsBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                account_detailsBindingSource.Position = 0; // Возвращаем в начало
            }
        }
        private string GetSelectedFieldName()
        {
            if (реквизиты_счётаDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return реквизиты_счётаDataGridView.Columns[реквизиты_счётаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
            }
            return null;
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            // Если чекбокс включен(фильтрация активирована)
            if (checkBoxFind.Checked)
            {
                // Проверка, что текст в поле поиска не пустой
                if (string.IsNullOrWhiteSpace(toolStripTextBoxFind.Text))
                {
                    MessageBox.Show("Вы ничего не задали для фильтрации!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string fieldName = GetSelectedFieldName(); // Получаем имя столбца для фильтрации
                if (string.IsNullOrEmpty(fieldName))
                {
                    MessageBox.Show("Выберите столбец для фильтрации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxFind.Checked = false;
                    return;
                }

                try
                {
                    // Если данные в DataTable, применяем фильтрацию
                    if (account_detailsBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            account_detailsBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            account_detailsBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка фильтрации: \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxFind.Checked = false;
                }
            }
            else
            {
                // Если чекбокс не выбран, показываем все данные, не фильтруем
                account_detailsBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (account_detailsBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
