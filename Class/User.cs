using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancePlatform.Class
{
    public abstract class User
    {
        //apply Encapsulation for data security
        private int user_id;
        private string username;
        private string password;
        private string usertype;
        public abstract MySqlDataReader CreateProfile();

        public int UserID { get; set; }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }

        public User()
        {

        }

        public User(string u, string p, string t)  //3 arguments constructor
        {
            this.username = u;
            this.password = p;
            this.usertype = t;
        }
    }
}
