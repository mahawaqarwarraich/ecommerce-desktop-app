using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ecommerce_App
{
    public partial class LoginForm : Form
    {

        public static bool IsAdmin = false;
        public static int CurrentUserId {  get; set; }
        public List<User> Users;
        public LoginForm()
        {
            InitializeComponent();
            Users = new List<User>();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
           string enteredPwd = txtPwd.Text;

            if (string.IsNullOrEmpty(username) ||  string.IsNullOrEmpty(enteredPwd))
            {
                MessageBox.Show("Username and password cannot be empty!");
            } else
            {
                Users = UserDBHelper.GetAllUsers();

                
                User user = Users.Find(usr => usr.Username == username);

                if (user != null)
                {
                    
                    bool isCorrectPwd = BCrypt.Net.BCrypt.Verify(enteredPwd, user.Password);
                    if (isCorrectPwd)
                    {
                        MessageBox.Show("Login successfully");
                        CurrentUserId = user.Id;



                        if (username == "admin345") IsAdmin = true;

                        if (IsAdmin)
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.ShowDialog();
                            IsAdmin = false;

                        }
                        else
                        {
                            UserForm userForm = new UserForm();
                            userForm.ShowDialog();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Username or Password incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                }


            }


        }

        private void newUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
