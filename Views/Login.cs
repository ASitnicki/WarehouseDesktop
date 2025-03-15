using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Views
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void langFlagEN_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void langFlagPL_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;

            if (login == "admin" && password == "admin")
            {
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                keepCredentialsBox.Checked = false;
                new WarehouseApp().Show();
                this.Hide();
            }
        }

        private void showPasswordBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }

        private void resetCredentials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void passwordTextBox_KeyPress(object sender, KeyEventArgs e)
        {

        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
