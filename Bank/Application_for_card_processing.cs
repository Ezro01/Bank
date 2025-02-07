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
    public partial class Application_for_card_processing : Form
    {
        public Application_for_card_processing()
        {
            InitializeComponent();
            if (UserSession.Role == "Manager_Clients")
            {
                dataGridViewTextBoxColumn2.Visible = false;
            }
            LoadEmplyeeComboBox();
            LoadNumber_ApplicationtsComboBox();
        }

        private void заявление_на_оформление_картыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.заявление_на_оформление_картыBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM  Заявление_на_оформление_карты"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)application_for_card_processingBindingSource.DataSource;
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

        private void Application_for_card_processing_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);

        }

        private static Application_for_card_processing afcp;
        public static Application_for_card_processing application_for_card_processing
        {
            get
            {
                if (afcp == null || afcp.IsDisposed) afcp = new Application_for_card_processing();
                return afcp;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource application_for_card_processingBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Заявление_на_оформление_карты";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    application_for_card_processingBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    заявление_на_оформление_картыDataGridView.DataSource = application_for_card_processingBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    заявление_на_оформление_картыBindingNavigator.BindingSource = application_for_card_processingBindingSource;
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
                if (!(application_for_card_processingBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = application_for_card_processingBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                application_for_card_processingBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                application_for_card_processingBindingSource.Position = 0; // Возвращаем в начало
            }
        }

        private string GetSelectedFieldName()
        {
            if (заявление_на_оформление_картыDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return заявление_на_оформление_картыDataGridView.Columns[заявление_на_оформление_картыDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                    if (application_for_card_processingBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            application_for_card_processingBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            application_for_card_processingBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
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
                application_for_card_processingBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (application_for_card_processingBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadEmplyeeComboBox()
        {
            if (UserSession.Role == "Admin_BD")
            {
                DataTable usersTable = new DataTable();
                string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT ID_Сотрудника, Фамилия, Имя, Отчество FROM Сотрудники_банка";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(usersTable);

                        // Добавляем новый столбец
                        usersTable.Columns.Add("FullEmplyee", typeof(string));

                        // Заполняем столбец вручную
                        foreach (DataRow row in usersTable.Rows)
                        {
                            row["FullEmplyee"] = $"{row["Фамилия"]} {row["Имя"]} {row["Отчество"]}";
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке паспортных данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (заявление_на_оформление_картыDataGridView.Columns["dataGridViewTextBoxColumn2"] is DataGridViewComboBoxColumn comboBoxColumn)
                {
                    comboBoxColumn.DataSource = usersTable;
                    comboBoxColumn.DisplayMember = "FullEmplyee";              // Показываем "Серия Номер"
                    comboBoxColumn.ValueMember = "ID_Сотрудника";             // В БД записываем ID
                }
            }
        }
        private void LoadNumber_ApplicationtsComboBox()
        {
            
            DataTable usersTable = new DataTable();
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Номер_счёта FROM Реквизиты_счёта";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(usersTable);

                    // Добавляем новый столбец
                    usersTable.Columns.Add("Number_Applicationts", typeof(string));

                    // Заполняем столбец вручную
                    foreach (DataRow row in usersTable.Rows)
                    {
                        row["Number_Applicationts"] = $"{row["Номер_счёта"]}";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке паспортных данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (заявление_на_оформление_картыDataGridView.Columns["dataGridViewTextBoxColumn3"] is DataGridViewComboBoxColumn comboBoxColumn)
            {
                comboBoxColumn.DataSource = usersTable;
                comboBoxColumn.DisplayMember = "Number_Applicationts";              // Показываем "Серия Номер"
                comboBoxColumn.ValueMember = "Номер_счёта";             // В БД записываем ID
            }
         
        }
    }
}
