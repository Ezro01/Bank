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
    public partial class Application_for_card_processing_user : Form
    {
        public Application_for_card_processing_user()
        {
            InitializeComponent();
            // Блокируем кнопку сохранения для пользователей с ролью Role_User
            vw_Заявление_на_оформление_карты_РольUserBindingNavigator.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
        }

        private void Application_for_card_processing_user_Load(object sender, EventArgs e)
        {
            LoadDataBasedOnRole(UserSession.Role, UserSession.Password);
        }

        private static Application_for_card_processing_user afcpu;
        public static Application_for_card_processing_user application_for_card_processing_user
        {
            get
            {
                if (afcpu == null || afcpu.IsDisposed) afcpu = new Application_for_card_processing_user();
                return afcpu;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        // Метод для загрузки данных с учётом роли пользователя
        private BindingSource application_for_card_processing_userBindingSource = new BindingSource();

        private void LoadDataBasedOnRole(string role, string password)
        {
            string connectionString = $"{UserSession.Server};Database=Bank_ultimate_version;User Id={UserSession.Username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_Заявление_на_оформление_карты_РольUser";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Привязываем данные к BindingSource
                    application_for_card_processing_userBindingSource.DataSource = dataTable;

                    // Привязываем BindingSource к DataGridView
                    vw_Заявление_на_оформление_карты_РольUserDataGridView.DataSource = application_for_card_processing_userBindingSource;

                    // Привязываем BindingSource к BindingNavigator
                    vw_Заявление_на_оформление_карты_РольUserBindingNavigator.BindingSource = application_for_card_processing_userBindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}\nКод ошибки: {ex.Number}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
