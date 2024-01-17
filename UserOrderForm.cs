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
    public partial class UserOrderForm : Form
    {
        List<Order> Orders {  get; set; }
        public UserOrderForm()
        {
            InitializeComponent();
            Orders = new List<Order>();
        }

        private void UserOrderForm_Load(object sender, EventArgs e)
        {
            Orders = OrderDBHelper.GetAllOrders();

            List<Order> myOrders;

           // myOrders = Orders.FindAll(ord => ord.UserId == LoginForm.CurrentUserId);
            myOrders = Orders.FindAll(ord => ord.UserId == LoginForm.CurrentUserId);

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = myOrders;
        }
    }
}
