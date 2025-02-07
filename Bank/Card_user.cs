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
    public partial class Card_user : Form
    {
        public Card_user()
        {
            InitializeComponent();
            // Блокируем кнопку сохранения для пользователей с ролью Role_User
            vw_Карта_РольUserBindingNavigator.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
        }

        private void Card_user_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Card_user cu;
        public static Card_user card_user
        {
            get
            {
                if (cu == null || cu.IsDisposed) cu = new Card_user();
                return cu;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        // Метод для загрузки данных с учётом роли пользователя
        private BindingSource card_userBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"Server={UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_Карта_РольUser";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    card_userBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    vw_Карта_РольUserDataGridView.DataSource = card_userBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    vw_Карта_РольUserBindingNavigator.BindingSource = card_userBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
