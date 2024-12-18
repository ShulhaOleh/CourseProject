using System;
using System.Windows.Forms;

namespace Hospital
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

            Doctor loggedInDoctor = null;

            using (var loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedInDoctor = loginForm.LoggedInDoctor;
                }
            }

            if (loggedInDoctor != null)
            {
                Application.Run(new frmMain(loggedInDoctor));
            }
        }
    }
}

