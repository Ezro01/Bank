using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank
{
    public partial class Pasport : Form
    {
        public Pasport()
        {
            InitializeComponent();
            // Проверка роли пользователя при загрузке формы
            if (UserSession.Role == "Role_User")
            {
                // Блокируем кнопку сохранения для пользователей с ролью Role_User
                паспортBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                toolStripTextBoxFind.Enabled = false;
                toolStripButtonFind.Enabled = false;
                checkBoxFind.Enabled = false;
                паспортDataGridView.ReadOnly = true;
            }
        }

        private void паспортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.паспортBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM Паспорт"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)passportBindingSource.DataSource;
                    dataAdapter.Update(dataTable); // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pasport_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Pasport p;
        public static Pasport pasport
        {
            get
            {
                if (p == null || p.IsDisposed) p = new Pasport();
                return p;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        // Метод для загрузки данных с учётом роли пользователя
        private BindingSource passportBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = role == "Role_User" ? "SELECT * FROM vw_Pasport_RoleUser WHERE Актуальный = 1" : "SELECT * FROM Паспорт";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    passportBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    паспортDataGridView.DataSource = passportBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    паспортBindingNavigator.BindingSource = passportBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Получение имени выбранного столбца
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
                if (!(passportBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = passportBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                passportBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passportBindingSource.Position = 0; // Возвращаем в начало
            }
        }

        // Получение имени столбца из DataGridView для поиска в DataTable
        private string GetSelectedFieldName()
        {
            if (паспортDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return паспортDataGridView.Columns[паспортDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
            }
            return null;
        }

        // Сброс фильтра при отключении чекбокса
        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            // Если чекбокс включен (фильтрация активирована)
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
                    if (passportBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            passportBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            passportBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
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
                passportBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (passportBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
