using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Ecommerce_App
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPwd.Text;

           if (isValidUsername(username) && isValidPwd(pwd))
            {
                User user = new User(username, pwd);
                user.Id = UserDBHelper.GetMaxId();
                string hashPwd = BCrypt.Net.BCrypt.HashPassword(user.Password);
                user.Password = hashPwd;
                UserDBHelper.Register(user);
                this.Close();

            }





        }

        private bool isValidUsername(string username)
        {
            if (!HasLetter(username) || !HasNumber(username) || ContainsSpace(username) || username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Username must be alphanumeric, may include an underscore, cannot contain spaces, and must be between 3 and 20 characters long");
                return false;
            }
            else
                return true;
           
        }

        private bool isValidPwd(string pwd)
        {
            if (!HasLetter(pwd) || !HasNumber(pwd) || ContainsSpace(pwd) || !HasSpecialCharacter(pwd) || pwd.Length < 4 || pwd.Length > 20)
            {
                MessageBox.Show("Password must be alphanumeric, may include an underscore, cannot contain spaces, atleast one special character and must be between 3 and 20 characters long");
                return false;
            }
            else
                return true;
        }

        // Functions

        private bool ContainsSpace(string input)
        {
            return input.Contains(" ");
        }

        private bool HasLetter(string input)
        {
            return Regex.IsMatch(input, "[a-zA-Z]");
        }

        private bool HasNumber(string input)
        {
            return Regex.IsMatch(input, "\\d");
        }

        private bool HasSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, "[^a-zA-Z0-9]");
        }
    }
}
