using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App
{
    internal class UserDBHelper
    {

       public static void Register(User user)
        {
            
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";


            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;


                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {

                    string query = "insert into E_User (user_id, username, password) values (@user_id, @username, @password)";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@user_id", user.Id);
                    sqlCommand.Parameters.AddWithValue("@username", user.Username);
                    sqlCommand.Parameters.AddWithValue("@password", user.Password);
                   

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show($"{user.Username} registered sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please check your input and try again");
                    }

                }

            }


        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = "Select * from E_User";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                               User user = new User();
                                user.Id = sqlDataReader.GetInt32(0);                                                                 
                                user.Username = sqlDataReader.GetString(1); 
                                user.Password = sqlDataReader.GetString(2);
                               
                                users.Add(user);
                                int usrLength = users.Count;
                            }
                        }
                    }
                }
            }

            return users;
        }

        public static int GetMaxId()
        {
           
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_dbb;Integrated Security=True";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) {

                sqlConnection.Open();

                int maxId = 0;

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                   

                    string query = "Select MAX(user_id) from E_User";


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

        public static string GetPwd(string enteredUsername)
        {
            string pwd = "";
            string connectionString = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=ecommerce_db;Integrated Security=True";


            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;


                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {

                    string query = "Select password from E_User where username = @enteredUsername";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@enteredUsername", enteredUsername);


                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                         pwd = sqlDataReader.GetString(0);
                    }
                    


                    if (!string.IsNullOrEmpty(pwd))
                    {

                        return pwd;
                    }
                    else
                    {
                        return "";
                    }
                   

                }
                return "";

            }
        }
    }
}
