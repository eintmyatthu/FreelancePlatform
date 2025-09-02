using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Class
{
    internal class UserFactory
    {
        public static User RegisterUser(string username, string password, string userType)
        {
            if (userType == "Freelancer")
                return new Freelancer(username, password);
            else
                return new Client(username, password);
        }
              
    }
}
