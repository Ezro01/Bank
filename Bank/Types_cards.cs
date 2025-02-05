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
    public partial class Types_cards : Form
    {
        public Types_cards()
        {
            InitializeComponent();
            if (UserSession.Role == "Role_User")
            {
                типы_картBindingNavigator.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                toolStripButtonFind.Enabled = false;
                checkBoxFind.Enabled = false;
                типы_картDataGridView.ReadOnly = true;
            }
        }

        private void типы_картBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Сначала валидируем и заканчиваем редактирование
            this.Validate();
            this.типы_картBindingSource.EndEdit();

            // Создаем новый SqlDataAdapter
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={UserSession.Password};";
            string query = "SELECT * FROM  Типы_карт"; // Тот же запрос для работы с данными

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                // Создаем команду для обновления
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                try
                {
                    // Обновляем базу данных с данными из BindingSource
                    DataTable dataTable = (DataTable)types_cardsBindingSource.DataSource;
                    dataAdapter.Update(dataTable); // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Types_cards_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Types_cards tc;
        public static Types_cards types_cards
        {
            get
            {
                if (tc == null || tc.IsDisposed) tc = new Types_cards();
                return tc;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource types_cardsBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = role == "Role_User" ?
                    "SELECT " +
                    "Тип_карты," +
                    "Описание," +
                    "Минимальный_баланс," +
                    "Сбор_за_обслуживание," +
                    "Лимит_снятия_наличных," +
                    "Лимит_переводов," +
                    "Кредитный_лимит," +
                    "Процентная_ставка," +
                    "Безпроцентный_период," +
                    "Максимальный_баланс " + // Обратите внимание на пробел в конце
                    "FROM Типы_карт"
                    :
                    "SELECT * FROM Типы_карт";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    types_cardsBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    типы_картDataGridView.DataSource = types_cardsBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    типы_картBindingNavigator.BindingSource = types_cardsBindingSource;
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
                if (!(types_cardsBindingSource.DataSource is DataTable dataTable) || !dataTable.Columns.Contains(fieldName))
                {
                    MessageBox.Show("Столбец не найден в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Поиск значения в столбце
                indexPos = types_cardsBindingSource.Find(fieldName, toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (indexPos > -1)
            {
                // Если нашли, устанавливаем позицию на найденный элемент
                types_cardsBindingSource.Position = indexPos;
            }
            else
            {
                // Если ничего не нашли, показываем сообщение
                MessageBox.Show("Таких данных нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                types_cardsBindingSource.Position = 0; // Возвращаем в начало
            }
        }

        private string GetSelectedFieldName()
        {
            if (типы_картDataGridView.CurrentCell != null)
            {
                // Получаем DataPropertyName столбца, а не его Name
                return типы_картDataGridView.Columns[типы_картDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                    if (types_cardsBindingSource.DataSource is DataTable dataTable)
                    {
                        if (dataTable.Columns[fieldName].DataType == typeof(string))
                        {
                            // Для строкового столбца применяем LIKE
                            types_cardsBindingSource.Filter = $"{fieldName} LIKE '%{toolStripTextBoxFind.Text}%'";
                        }
                        else
                        {
                            // Для других типов данных (например, числовых) применяем равно
                            types_cardsBindingSource.Filter = $"{fieldName} = {toolStripTextBoxFind.Text}";
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
                types_cardsBindingSource.Filter = "";
            }

            // Если после фильтрации не найдено строк, показываем сообщение
            if (types_cardsBindingSource.Count == 0)
            {
                if (checkBoxFind.Checked)
                {
                    MessageBox.Show("Нет совпадений по фильтру!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
