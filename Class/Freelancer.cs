using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Class
{
    internal class Freelancer : User, IProjectObserver
    {
        DataConnection dbObj = new DataConnection();

        public int FreelancerId { get; private set; }
        public string Skills { get; private set; }
        public string Portfolio { get; private set; }
        public string Expertise { get; private set; }
        public string PastWork { get; private set; }

        private List<string> notifications = new List<string>();

        public Freelancer(string username, string password)
        {
            Username = username;
            Password = password;
            Usertype = "Freelancer";
        }

        public Freelancer(int id, string skills)
        {
            FreelancerId = id;
            Skills = skills;
        }

        public void Update(string message)
        {
            notifications.Add(message);
            MessageBox.Show(message, "New Project Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Freelancer(int freelancerId, string skills, string portfolio, string expertise, string pastwork)
        {
            FreelancerId = freelancerId;
            Skills = skills;
            Portfolio = portfolio;
            Expertise = expertise;
            PastWork = pastwork;
        }
        public override MySqlDataReader CreateProfile()
        {
            dbObj.cnOpen();

            string query = "SELECT skills, expertise, portfolio, pastwork FROM freelancer WHERE freelancer_id = @FreelancerId";

            MySqlDataReader reader = dbObj.ExecuteReader(query, ("@FreelancerId", FreelancerId));

            return reader;
            dbObj.cnClose();
        }

    }

}
