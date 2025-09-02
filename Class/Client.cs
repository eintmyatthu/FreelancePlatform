using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreelancePlatform.Class
{
    internal class Client:User
    {
        public int ClientId { get; set; }     
        public string Company { get; set; }
        public string ContactNumber { get; set; }
        DataConnection dbObj = new DataConnection();
        public Client(int clientId, string company, string contactNumber)
        {
            ClientId = clientId;            
            Company = company;
            ContactNumber = contactNumber;
        }

        public Client(string username, string password)
        {
            Username = username;
            Password = password;
            Usertype = "Client";
        }


        public override MySqlDataReader CreateProfile()
        {
            dbObj.cnOpen();
            string query = "SELECT company,contactNo FROM client WHERE client_id = @ClientId";
            MySqlDataReader reader = dbObj.ExecuteReader(query, ("@ClientId", ClientId));

            return reader;
            dbObj.cnClose();
        }

       

    }
}
