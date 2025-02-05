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
    public partial class User_user : Form
    {
        public User_user()
        {
            InitializeComponent();
            vw_Пользователь_ПрофильBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void User_user_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static User_user uu;
        public static User_user user_user
        {
            get
            {
                if (uu == null || uu.IsDisposed) uu = new User_user();
                return uu;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private BindingSource user_userBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server=DESKTOP-3P3899D\\SQLEXPRESS;Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_Пользователь_Профиль";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    user_userBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    vw_Пользователь_ПрофильDataGridView.DataSource = user_userBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    vw_Пользователь_ПрофильBindingNavigator.BindingSource = user_userBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
