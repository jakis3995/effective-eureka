using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingTask
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void changePassViewButton_Click(object sender, EventArgs e)
        {
            if (passTB.UseSystemPasswordChar == true)
            {
                passTB.UseSystemPasswordChar = false;
            } else
            {
                passTB.UseSystemPasswordChar = true;
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            // Проверка данных по бд, авторизация и выход в новое окно
            bool canPass = SQLiteDataAccess.Authentification(loginTB.Text, passTB.Text);
            if (canPass)
            {
                MainForm mainForm = new MainForm(this);
                if (SQLiteDataAccess.person.SuperUser)
                {
                    mainForm.StripMenuForSuperUserVisibility(true);
                }
                else
                {
                    mainForm.StripMenuForSuperUserVisibility(false);
                }
                mainForm.Text = SQLiteDataAccess.person.Name;
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка аутентификации", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void loginTB_TextChanged(object sender, EventArgs e)
        {
            passTB.Clear();
        }

        private void passTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton_Click(sender, e);
            }
        }
    }
}
