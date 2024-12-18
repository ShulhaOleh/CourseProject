using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Hospital.Properties;

namespace Hospital
{
    public partial class frmLogin : Form
    {
        public Doctor LoggedInDoctor { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            LoadSavedCredentials();
        }

        private void LoadSavedCredentials()
        {
            chkRememberMe.Checked = Settings.Default.RememberMe;

            if (chkRememberMe.Checked)
            {
                // Завантажуємо збережений логін
                if (!string.IsNullOrEmpty(Settings.Default.SavedUsername))
                    txtLogin.Text = Settings.Default.SavedUsername;

                // Завантажуємо збережений пароль, якщо він розшифровується коректно
                if (!string.IsNullOrEmpty(Settings.Default.SavedPassword))
                {
                    string decryptedPassword = DecryptPassword(Settings.Default.SavedPassword);
                    if (!string.IsNullOrEmpty(decryptedPassword))
                    {
                        txtPassword.Text = decryptedPassword;
                    }
                }
            }

            // Встановлення плейсхолдерів ТІЛЬКИ для порожніх полів
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
                Placeholder.SetPlaceholder(txtLogin, "Введіть логін...");

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                Placeholder.SetPlaceholder(txtPassword, "Введіть пароль...");
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredLogin = ComputeMD5Hash(txtLogin.Text);
            string enteredPassword = ComputeMD5Hash(txtPassword.Text);

            // XML Path
            string xmlFilePath = "../../XML/users.xml";
            var doc = XDocument.Load(xmlFilePath);

            var user = doc.Element("Users")
                         ?.Elements("User")
                         ?.FirstOrDefault(u =>
                              u.Element("Login")?.Value == enteredLogin &&
                              u.Element("Password")?.Value == enteredPassword);

            if (user != null)
            {
                int doctorID = int.Parse(user.Element("ID")?.Value);

                DatabaseHelper dbHelper = new DatabaseHelper();
                LoggedInDoctor = dbHelper.GetDoctorFromDatabase(doctorID);

                if (LoggedInDoctor != null)
                {
                    Settings.Default.RememberMe = chkRememberMe.Checked;

                    if (chkRememberMe.Checked)
                    {
                        Settings.Default.SavedUsername = txtLogin.Text;
                        Settings.Default.SavedPassword = EncryptPassword(txtPassword.Text);
                    }
                    else
                    {
                        Settings.Default.SavedUsername = string.Empty;
                        Settings.Default.SavedPassword = string.Empty;
                    }

                    Settings.Default.Save();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Дані лікаря не знайдено у базі даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private string EncryptPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(data);
        }

        private string DecryptPassword(string encryptedPassword)
        {
            try
            {
                byte[] data = Convert.FromBase64String(encryptedPassword);
                return Encoding.UTF8.GetString(data);
            }
            catch
            {
                return string.Empty;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.TabStop = false;
            txtPassword.TabStop = false;
        }
    }
}
