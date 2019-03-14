using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOutlookLogin {
    public class Login {

        //Declare properties 
        public List<string> lstUsername { get; set; }
        public List<string> lstPassword { get; set; }

        //intialise  
        public Login() {
            lstUsername = new List<string>();
            lstPassword = new List<string>();

            lstUsername.Add("admin1");
            lstUsername.Add("admin2");
            lstUsername.Add("admin3");

            lstPassword.Add("1234");
        }

              
        //Login validation - returns true or false based on input
        public bool IsLoggedIn(string user, string pass) {
            //check user name empty 
            if (string.IsNullOrEmpty(user)) {
                MessageBox.Show("Enter the user name!");
                return false;
            }
           
            //check user name is correct 
            else {
                if (!lstUsername.Contains(user)) {
                    MessageBox.Show("User name is incorrect!");
                    return false;
                }
                //check password is empty 
                else {
                    if (string.IsNullOrEmpty(pass)) {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                   
                    //check password is correct 
                    else if (!lstPassword.Contains(pass)) {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    } else {
                        return true; //return true after validation
                    }
                }
            }
        }

    }
}
