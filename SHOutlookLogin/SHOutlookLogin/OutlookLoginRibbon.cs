using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;

namespace SHOutlookLogin {
    public partial class OutlookLoginRibbon {
        Microsoft.Office.Interop.Outlook.Application outlookApp;
        ThisAddIn outlookAddin;
        private void OutlookLoginRibbon_Load(object sender, RibbonUIEventArgs e) {
            outlookApp = Globals.ThisAddIn.Application as Microsoft.Office.Interop.Outlook.Application;
            outlookAddin = Globals.ThisAddIn;
            CheckLoginStatus();
        }

        //Check current login status and display respective menu button
        private void CheckLoginStatus() {
            if (Properties.Settings.Default.LoginStatus == "LoggedIn") {
                menuButton1.Items.Add(btnLogout);
            } else {
                menuButton1.Items.Add(btnLogin);
            }
        }

        //Logout button click event
        private void BtnLogout_Click(object sender, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs e) {
            Properties.Settings.Default.LoginStatus = "LoggedOut";
            Properties.Settings.Default.Save();
            menuButton1.Items.Clear();
            menuButton1.Items.Add(btnLogin);
            MessageBox.Show("You have been Logged out successfully");
        }

        //Login button click event
        private void BtnLogin_Click(object sender, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs e) {
            //Navigate to login form
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            //After succesfull login changes the menu item
            if (LoginForm.IsLoginSuccess) {
                menuButton1.Items.Clear();
                menuButton1.Items.Add(btnLogout);
            }
        }


    }
}


