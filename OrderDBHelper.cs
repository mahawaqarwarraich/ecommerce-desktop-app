using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App
{
    internal class OrderDBHelper
    {

        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = @"
    SELECT E_Order.order_Id, E_Order.user_id, E_Order.order_date, E_Order.total_amount, E_Order.status, E_Order.payment, E_User.username
    FROM E_Order
    INNER JOIN E_User ON E_Order.user_id = E_User.user_id;
";


                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Order  order = new Order();
                                order.Id = sqlDataReader.GetInt32(0);  
                                order.UserId = sqlDataReader.GetInt32(1);
                                order.OrderDate = sqlDataReader.GetDateTime(2);
                                order.TotalAmount = (double)sqlDataReader.GetDecimal(3);
                                order.Status = sqlDataReader.GetString(4);
                               

                                order.Payment = sqlDataReader.GetString(5);
                                order.Buyer = sqlDataReader.GetString(6);
                               
                                
                                orders.Add(order);
                              
                            }
                        }
                    }
                }
            }

            return orders;
        }

        public static void AddNewOrder(Order order)
        {
            // 1. Prepare a connection string consisting of server name and database name connected to the server.
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            // 2. Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;

            // 3. Open connection
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {


              
                string query = "insert into E_Order (order_id, user_id, order_date, total_amount, status, payment) values (@order_id, @user_id, @order_date, @total_amount, @status, @payment)";



                // 5. Execute query

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@order_id", order.Id);
                sqlCommand.Parameters.AddWithValue("@user_id", order.UserId);
                sqlCommand.Parameters.AddWithValue("@order_date", order.OrderDate);
                sqlCommand.Parameters.AddWithValue("@total_amount", order.TotalAmount);
                sqlCommand.Parameters.AddWithValue("@status", order.Status);
                sqlCommand.Parameters.AddWithValue("@payment", order.Payment);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Order placed successfully!");
                }
                // 5. Close connection
                sqlConnection.Close();
            }
           

        }


        public static int GetMaxId()
        {

            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();

                int maxId = 0;

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {


                    string query = "Select MAX(order_id) from E_Order";


                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


                    object result = sqlCommand.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                    }



                }
                return maxId + 1;
            }


        }

        public static void ChangeOrderStatus(int orderId, string newStatus)
        {
           
                // 1. Prepare connection string consisting of server name and database name connected to the server.
                string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

                // 2. Establish connection
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // 3. Open connection
                    sqlConnection.Open();

                    if (sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        // 4. Prepare query
                        string query = "UPDATE E_Order SET status = @NewStatus WHERE order_id = @Id";

                        // 5. Execute query
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@Id", orderId);
                            sqlCommand.Parameters.AddWithValue("@NewStatus", newStatus);

                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Status changed successfully!");
                            }
                        }
                    }
                }

           

        }
    }
}
