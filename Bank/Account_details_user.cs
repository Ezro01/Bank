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
    public partial class Account_details_user : Form
    {
        public Account_details_user()
        {
            InitializeComponent();
            if (UserSession.Role == "Role_User")
            {
                // Блокируем кнопку сохранения для пользователей с ролью Role_User
                vw_Реквизиты_счёта_РольUserBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
        }

        private void Account_details_user_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Account_details_user adu;
        public static Account_details_user account_details_user
        {
            get
            {
                if (adu == null || adu.IsDisposed) adu = new Account_details_user();
                return adu;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        // Метод для загрузки данных с учётом роли пользователя
        private BindingSource account_details_userBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_Реквизиты_счёта_РольUser";
                    

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    account_details_userBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    vw_Реквизиты_счёта_РольUserDataGridView.DataSource = account_details_userBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    vw_Реквизиты_счёта_РольUserBindingNavigator.BindingSource = account_details_userBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
