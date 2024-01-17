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
    public partial class OrderForm : Form
    {
        public static int SelectedOrderId { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            var orders = OrderDBHelper.GetAllOrders();
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOrders.Rows[0];
                SelectedOrderId = (int)selectedRow.Cells[0].Value;
            }
            PopulateDGV();
            


        }

        public void PopulateDGV()
        {
            var orders = OrderDBHelper.GetAllOrders();
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders;
        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            OrderStatusForm orderStatusform = new OrderStatusForm();
           
            if (orderStatusform.ShowDialog() == DialogResult.OK)
            {
                PopulateDGV();

            }
        }

        private void dgvOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvOrders.Rows[e.RowIndex];

           
            SelectedOrderId = (int) selectedRow.Cells[0].Value;
        }
    }
}
