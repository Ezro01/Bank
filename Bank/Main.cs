using Bank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (UserSession.Role == "Manager_Clients")
            {
                сотрудникиToolStripMenuItem.Enabled = false;
                сотрудникиToolStripMenuItem.Visible = false;
            }

            if (UserSession.Role == "Role_User")
            {
                сотрудникиToolStripMenuItem.Enabled = false;
                сотрудникиToolStripMenuItem.Visible = false;
            }
        }



        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void паспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Role_User")
            {
                Pasport_user.pasport_user.ShowForm();
            }

            else
            {
                Pasport.pasport.ShowForm();
            }
        }


        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Role_User")
            {
                User_user.user_user.ShowForm();
            }

            else
            {
                User.user.ShowForm();
            }
                
        }

        private void реквизитыСчётаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Role_User")
            {
                Account_details_user.account_details_user.ShowForm();
            }

            else
            {
                Account_details.account_details.ShowForm();
            }
        }

        private void заявлениеНаОформлениеКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Role_User")
            {
                Application_for_card_processing_user.application_for_card_processing_user.ShowForm();
            }

            else
            {
                Application_for_card_processing.application_for_card_processing.ShowForm();
            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Admin_BD")
            {
                Bank_employees.bank_employees.ShowForm();
            }

            else
            {
                MessageBox.Show("У вас нет доступа к этой таблице!", "Не пройдёшь :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Role_User")
            {
                Card_user.card_user.ShowForm();
            }

            else
            {
                Card.card.ShowForm();
            }
        }

        private void типыКартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Types_cards.types_cards.ShowForm();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(С) ТУСУР, БИС, ФБ, Зверков Роман Алексеевич, 742-1", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("АИС с учебно-исследовательской базой данной 'Оформление и получение банковской карты'", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
