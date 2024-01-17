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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

       

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            cmbPayment.SelectedIndex = 0;
            txtSubtotal.Text = UserProductForm.Total.ToString();
            txtTotal.Text = UserProductForm.Total.ToString();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            // Insert order
            Order order = new Order();
            order.Id = OrderDBHelper.GetMaxId();
            order.UserId = LoginForm.CurrentUserId;
            order.OrderDate = DateTime.Now;
            order.TotalAmount = UserProductForm.Total;
            switch(cmbPayment.SelectedIndex)
            {
                case 0:
                    order.Payment = "Credit Card";
                    break;
                case 1:
                    order.Payment = "Cash on Delivery";
                    break;
                case 2:
                    order.Payment = "PayPal";
                    break;


            }
            OrderDBHelper.AddNewOrder(order);
            this.Close();
            
    }
    }
}
