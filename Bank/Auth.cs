using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank
{
    public partial class Auth : Form
    {
        private string serverFilePath = "C:\\Все папки по жизни\\Универ\\5 семестр\\Курсовая БСБД\\Приложение\\Bank\\Bank\\server.txt";  // Путь к файлу с серверами
        private string databaseName = "Bank_ultimate_version";  // Название базы данных

        public Auth()
        {
            InitializeComponent();
            LoadServerNames(); // Загружаем сервера при старте программы
        }

        private void LoadServerNames()
        {
            if (File.Exists(serverFilePath))
            {
                // Читаем все серверы из файла и убираем пустые или дублирующиеся строки
                string[] servers = File.ReadAllLines(serverFilePath)
                                       .Select(s => s.Trim())
                                       .Where(s => !string.IsNullOrEmpty(s))
                                       .Distinct()
                                       .ToArray();

                if (servers.Length > 0)
                {
                    textBox_server.Text = servers[0];  // Автозаполнение первым сервером
                }
                else
                {
                    MessageBox.Show("Нет доступных серверов в файле.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Файл с серверами не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveServerName(string serverName)
        {
            // Проверяем, если сервер не пустой и его нет в списке
            if (!string.IsNullOrWhiteSpace(serverName))
            {
                string[] existingServers = File.Exists(serverFilePath)
                    ? File.ReadAllLines(serverFilePath)
                    : Array.Empty<string>();

                // Добавляем сервер в файл, если его нет
                if (!existingServers.Contains(serverName))
                {
                    File.AppendAllText(serverFilePath, serverName + Environment.NewLine);
                }
            }
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            string username = textBox_auth.Text;
            string password = textBox_pass.Text;
            string serverName = textBox_server.Text;  // Читаем сервер из textBox_server

            if (string.IsNullOrWhiteSpace(serverName))
            {
                MessageBox.Show("Ошибка: Имя сервера не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохраняем сервер в файл
            SaveServerName(serverName);

            // Пытаемся подключиться к БД
            if (TryConnectToDatabase(username, password, serverName))
            {
                string role = AssignRoleBasedOnUsername(username);
                if (role != null)
                {
                    UserSession.SetUser(username, role, password, serverName); // Запоминаем сессию пользователя
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка: Роль не найдена для этого пользователя.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Неверный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryConnectToDatabase(string username, string password, string serverName)
        {
            string connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";
            MessageBox.Show($"Подключение к серверу: {serverName}", "Отладка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Подключение успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка подключения:\n\nКод ошибки: {ex.Number}\nСообщение: {ex.Message}",
                                "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Метод для назначения роли на основе имени пользователя
        private string AssignRoleBasedOnUsername(string username)
        {
            // Извлекаем часть имени до первого подчеркивания
            string baseUsername = username.Split('_')[0];

            // Назначаем роль в зависимости от первой части имени
            if (baseUsername.Equals("Userlogin", StringComparison.OrdinalIgnoreCase))
            {
                return "Role_User";
            }
            else if (baseUsername.Equals("ManagerLogin", StringComparison.OrdinalIgnoreCase))
            {
                return "Manager_Clients";
            }
            else if (baseUsername.Equals("AdminLogin", StringComparison.OrdinalIgnoreCase))
            {
                return "Admin_BD";
            }
            else
            {
                return null; // Для неизвестных логинов возвращаем null
            }
        }
    }
}
