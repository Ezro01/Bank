using System;
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
    public partial class Bank_employees : Form
    {
        public Bank_employees()
        {
            InitializeComponent();
        }

        private void сотрудники_банкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.сотрудники_банкаBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM Сотрудники_банка"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)bank_employeesBindingSource.DataSource;
                    dataAdapter.Update(dataTable); // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Bank_employees_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Bank_employees be;
        public static Bank_employees bank_employees
        {
            get
            {
                if (be == null || be.IsDisposed) be = new Bank_employees();
                return be;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource bank_employeesBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Сотрудники_банка";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    bank_employeesBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    сотрудники_банкаDataGridView.DataSource = bank_employeesBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    сотрудники_банкаBindingNavigator.BindingSource = bank_employeesBindingSource;
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
                if (!(bank_employeesBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = bank_employeesBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                bank_employeesBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bank_employeesBindingSource.Position = 0; // Возвращаем в начало
            }
        }

        private string GetSelectedFieldName()
        {
            if (сотрудники_банкаDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return сотрудники_банкаDataGridView.Columns[сотрудники_банкаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                    if (bank_employeesBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            bank_employeesBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            bank_employeesBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
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
                bank_employeesBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (bank_employeesBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
