using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Auth authForm = new Auth();

            // Если авторизация успешна, запускаем главную форму
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());  // Открываем главную форму после успешной авторизации
            }
            else
            {
                // Если авторизация не успешна, завершаем приложение
                Application.Exit();
            }
        }
    }
}
