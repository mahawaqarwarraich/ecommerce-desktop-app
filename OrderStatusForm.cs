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
    public partial class OrderStatusForm : Form
    {
        List<Order> Orders;
        public OrderStatusForm()
        {
            InitializeComponent();
        }

        private void OrderStatusForm_Load(object sender, EventArgs e)
        {
            cmbOrdStatus.SelectedIndex = 0;
            Orders = new List<Order>();
            Orders = OrderDBHelper.GetAllOrders();
          
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string newStatus = "Pending";

            switch(cmbOrdStatus.SelectedIndex)
            {
                case 0:
                    newStatus = "Not Processed";
                    break;
                case 1:
                    newStatus = "Processing";
                    break;
                case 2:
                    newStatus = "Shipped";
                    break;
                case 3:
                    newStatus = "Delivered";
                    break;
                case 4:
                    newStatus = "Cancelled";
                    break;

            }

            OrderDBHelper.ChangeOrderStatus(OrderForm.SelectedOrderId, newStatus);
            var orderToUpdate = Orders.Find(order => order.Id == OrderForm.SelectedOrderId);
            orderToUpdate.Status = newStatus;

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
