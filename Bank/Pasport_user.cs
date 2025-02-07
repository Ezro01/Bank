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
    public partial class Pasport_user : Form
    {
        public Pasport_user()
        {
            InitializeComponent();
            if (UserSession.Role == "Role_User")
            {
                // Блокируем кнопку сохранения для пользователей с ролью Role_User
                vw_Pasport_RoleUserBindingNavigatorSaveItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
            }
        }

        private void Pasport_user_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);

        }

        private static Pasport_user pu;
        public static Pasport_user pasport_user
        {
            get
            {
                if (pu == null || pu.IsDisposed) pu = new Pasport_user();
                return pu;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        // Метод для загрузки данных с учётом роли пользователя
        private BindingSource passport_userBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_Pasport_RoleUser WHERE Актуальный = 1";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    passport_userBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    vw_Pasport_RoleUserDataGridView.DataSource = passport_userBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    vw_Pasport_RoleUserBindingNavigator.BindingSource = passport_userBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
