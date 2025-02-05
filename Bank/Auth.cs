using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private string serverName = "DESKTOP-3P3899D\\SQLEXPRESS"; // Имя сервера
        private string databaseName = "Bank_ultimate_version";    // Название базы данных

        private void button_auth_Click(object sender, EventArgs e)
        {
            string username = textBox_auth.Text;
            string password = textBox_pass.Text;

            // Попытка подключения к базе данных с использованием введённых логина и пароля
            if (TryConnectToDatabase(username, password))
            {
                // Назначаем роль в зависимости от логина пользователя
                string role = AssignRoleBasedOnUsername(username);

                // Проверяем, что роль назначена, и продолжаем авторизацию
                if (role != null)
                {
                    // Запоминаем роль, пользователя и пароль
                    UserSession.SetUser(username, role, password);

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
                MessageBox.Show("Ошибка: Неверные логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для подключения к базе данных и проверки логина и пароля
        private bool TryConnectToDatabase(string username, string password)
        {
            string connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 18456) // Ошибка аутентификации
                {
                    MessageBox.Show("Ошибка: Неверный логин или пароль.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
