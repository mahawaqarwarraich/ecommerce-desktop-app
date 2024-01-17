using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Ecommerce_App
{
    public class User
    {

        // Properties
        public int Id { get; set; }

        public string Username { get; set; }
      
        public string Password { get; set; }
       

        // Constructor
        public User() { 
            
        }

        // Constructor
        public User(string username, string pwd)
        {
            Username = username;
            Password = pwd;
        }




    }
}
