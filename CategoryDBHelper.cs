using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App
{
    internal class CategoryDBHelper
    {

        public static List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT " +
                                   "Category.category_id, " +
                                   "Category.name " +
                                   "FROM " +
                                   "Category";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Category category = new Category();
                                category.Id = sqlDataReader.GetInt32(0); // category_id                                                                  
                                category.Name = sqlDataReader.GetString(1); // name
                                categories.Add(category);
                            }
                        }
                    }
                }
            }

            return categories;
        }

        public static void AddNewCategory(Category category)
        {
            // 1. Prepare a connection string consisting of server name and database name connected to the server.
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            // 2. Establish connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // 3. Open connection
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    // 4. Prepare query
                    string query = "INSERT INTO Category (category_id, name) VALUES (@category_id, @name)";

                    // 5. Execute query
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@category_id", category.Id);
                        sqlCommand.Parameters.AddWithValue("@name", category.Name);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Operation Successful");
                        }
                    }
                }
            }
           
        }

        public static void DeleteCategory(Category category)
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
                    string query = "DELETE FROM Category WHERE category_id = @Id";

                    // 5. Execute a query
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", category.Id);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted successfully");
                        }
                    }
                }
            }
        }


        public static void UpdateCategory(Category category)
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
                    string query = "UPDATE Category SET name = @Name WHERE category_id = @Id";

                    // 5. Execute query
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", category.Id);
                        sqlCommand.Parameters.AddWithValue("@Name", category.Name);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Operation Successful");
                        }
                    }
                }
            }
           
        }

        public static List<int> GetCatIds()
        {
            List<int> categoryIds = new List<int>();

            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {

                   

                    string query = "SELECT " +
                                   "Category.category_id " +
                                 
                                   "FROM " +
                                   "Category";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                       
                            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                            if (sqlDataReader.HasRows)
                            {
                           

                            while (sqlDataReader.Read())
                                {
                                   categoryIds.Add(sqlDataReader.GetInt32(0));

                                }
                            return categoryIds;

                        }
                    }
                    return categoryIds;
                }

                return categoryIds;

               
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
                    string query = "SELECT MAX(category_id) FROM Category";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        object result = sqlCommand.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            maxId = Convert.ToInt32(result);
                        }
                    }
                }

                return maxId + 1;
            }
        }


    }
}
