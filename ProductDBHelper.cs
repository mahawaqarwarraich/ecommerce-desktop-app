using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App
{
    internal class ProductDBHelper
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT " +
                                   "Product.product_id, " +
                                   "Product.name, " +
                                   "Product.description, " +
                                   "Product.price, " +
                                   "Product.quantity, " +
                                   "Category.name " +
                                   "FROM " +
                                   "Product " +
                                   "INNER JOIN Category ON Product.category_id = Category.category_id";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Product product = new Product();
                                product.Id = sqlDataReader.GetInt32(0); // product_id                                                                  
                                product.Name = sqlDataReader.GetString(1); // name                                                            
                                product.Description = sqlDataReader.IsDBNull(2) ? null : sqlDataReader.GetString(2); // description                           
                                product.EPrice = (double)sqlDataReader.GetDecimal(3); // price
                                product.EQty = sqlDataReader.GetInt32(4); //quantity
                                product.CategoryName = sqlDataReader.GetString(5);//category name
                                products.Add(product);
                            }
                        }
                    }
                }
            }

            return products;
        }

        public static void AddNewProduct(Product product)
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
                

               
                string query = "insert into Product (product_id, name, description, price, quantity, category_id) values (@product_id, @name, @description, @price, @quantity, @category_id)";



                // 5. Execute query

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@product_id", product.Id);
                sqlCommand.Parameters.AddWithValue("@name", product.Name);
                sqlCommand.Parameters.AddWithValue("@description", product.Description);
                sqlCommand.Parameters.AddWithValue("@price", product.EPrice);
                sqlCommand.Parameters.AddWithValue("@quantity", product.EQty);
                sqlCommand.Parameters.AddWithValue("@category_id", product.CategoryId);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Operation Successful");
                }

            }
            // 5. Close connection
            sqlConnection.Close();

        }

        public static void UpdateProduct(Product product)
        {
            // 1. Prepare connection string consisting of server name and database name connected to the server.
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            // 2. Establish connection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // 3. Open connection
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                

                // 4. Prepare query
                string query = "Update Product  Set name = @Name, description = @Description, price = @EPrice, quantity = @EQty, category_id = @CategoryId where product_id = @Id";

                // 5. Execute query
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Id", product.Id);
                sqlCommand.Parameters.AddWithValue("@Name", product.Name);
                sqlCommand.Parameters.AddWithValue("@Description", product.Description);
                sqlCommand.Parameters.AddWithValue("@EPrice", product.EPrice);
                sqlCommand.Parameters.AddWithValue("@EQty", product.EQty);
                sqlCommand.Parameters.AddWithValue("@CategoryId", product.CategoryId);


                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Operation Successful");
                }
            }



        }

        public static void DeleteProduct(Product product)
        {
            // 1. Prepare a connection string consisting of server name and database name connected to it
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            // 2. Establish connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // 3. Open connection
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {

                    // 4. Prepare a query
                    string query = "Delete from product where product_id = @Id";

                    // 5. Execute a query
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@Id", product.Id);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Record Deleted successfully");

                       

                    }
                  
                }
              

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


                    string query = "Select MAX(product_id) from Product";


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
    }
}
