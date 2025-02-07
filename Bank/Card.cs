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
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
            LoadNumberComboBox();
            LoadID_Types_CarsComboBox();
        }

        private void картаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.картаBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM Карта"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)cardBindingSource.DataSource;
                    dataAdapter.Update(dataTable); // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Card_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Card c;
        public static Card card
        {
            get
            {
                if (c == null || c.IsDisposed) c = new Card();
                return c;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource cardBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Карта";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    cardBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    картаDataGridView.DataSource = cardBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    картаBindingNavigator.BindingSource = cardBindingSource;
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
                if (!(cardBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = cardBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                cardBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cardBindingSource.Position = 0; // Возвращаем в начало
            }
        }

        private string GetSelectedFieldName()
        {
            if (картаDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return картаDataGridView.Columns[картаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                    if (cardBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            cardBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            cardBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
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
                cardBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (cardBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadNumberComboBox()
        {
            DataTable usersTable = new DataTable();
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Номер_заявления FROM Заявление_на_оформление_карты";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(usersTable);

                    // Добавляем новый столбец
                    usersTable.Columns.Add("FullNumber", typeof(string));

                    // Заполняем столбец вручную
                    foreach (DataRow row in usersTable.Rows)
                    {
                        row["FullNumber"] = $"{row["Номер_заявления"]}";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке паспортных данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (картаDataGridView.Columns["dataGridViewTextBoxColumn2"] is DataGridViewComboBoxColumn comboBoxColumn)
            {
                comboBoxColumn.DataSource = usersTable;
                comboBoxColumn.DisplayMember = "FullNumber";              // Показываем "Серия Номер"
                comboBoxColumn.ValueMember = "Номер_заявления";             // В БД записываем ID
            }
        }


        private void LoadID_Types_CarsComboBox()
        {
            DataTable usersTable = new DataTable();
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Типа_карты, Описание FROM Типы_карт";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(usersTable);

                    // Добавляем новый столбец
                    usersTable.Columns.Add("FullID_cards", typeof(string));

                    // Заполняем столбец вручную
                    foreach (DataRow row in usersTable.Rows)
                    {
                        row["FullID_cards"] = $"{row["Описание"]}";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке паспортных данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (картаDataGridView.Columns["dataGridViewTextBoxColumn3"] is DataGridViewComboBoxColumn comboBoxColumn)
            {
                comboBoxColumn.DataSource = usersTable;
                comboBoxColumn.DisplayMember = "FullID_cards";              // Показываем "Серия Номер"
                comboBoxColumn.ValueMember = "ID_Типа_карты";             // В БД записываем ID
            }
        }
    }
}
