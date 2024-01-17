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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

      
        private void UserForm_Load(object sender, EventArgs e)
        {
            UserProductForm.Total = 0;
           

            UserProductForm userProductForm = new UserProductForm();

            userProductForm.ControlBox = false;
            userProductForm.FormBorderStyle = FormBorderStyle.None;

            userProductForm.TopLevel = false;
            userProductForm.Dock = DockStyle.Fill;

            panelProducts.Controls.Clear();
            panelProducts.Controls.Add(userProductForm);

            userProductForm.Show();


        }

        private void viewProductsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserProductForm userProductForm = new UserProductForm();

            userProductForm.ControlBox = false;
            userProductForm.FormBorderStyle = FormBorderStyle.None;

            userProductForm.TopLevel = false;
            userProductForm.Dock = DockStyle.Fill;

            panelProducts.Controls.Clear();
            panelProducts.Controls.Add(userProductForm);

            userProductForm.Show();

        }

        private void myOrdersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserOrderForm userOrderForm = new UserOrderForm();

            userOrderForm.ControlBox = false;
            userOrderForm.FormBorderStyle = FormBorderStyle.None;

            userOrderForm.TopLevel = false;
            userOrderForm.Dock = DockStyle.Fill;

            panelProducts.Controls.Clear();
            panelProducts.Controls.Add(userOrderForm);

           
            userOrderForm.Show();

        }

        private void checkoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            if (UserProductForm.Total > 0)
            {
              
              checkoutForm.ShowDialog();
            } else
            {
                MessageBox.Show("Please first add itemds to the cart!");
            }
            
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
