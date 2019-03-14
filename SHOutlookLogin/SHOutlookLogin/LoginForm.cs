using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOutlookLogin {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        Login login = new Login();

        public static bool IsLoginSuccess;
        private void LoginButton_Click(object sender, System.EventArgs e) {
            if (login.IsLoggedIn(nametxtbox.Text, pwdtxtbox.Text)) {
                IsLoginSuccess = true;
                MessageBox.Show("You are logged in successfully");
                Properties.Settings.Default.LoginStatus = "LoggedIn";
                Properties.Settings.Default.Save();
                this.Close();
                this.Dispose();
            } else {
                IsLoginSuccess = false;
                //show login error message 
                MessageBox.Show("Login Error!");
            }
        }

    }
}
