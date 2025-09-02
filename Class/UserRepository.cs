using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FreelancePlatform.Class
{
    internal class UserRepository
    {
        DataConnection dbObj = new DataConnection();

        public void register(User user)
        {
            dbObj.cnOpen();

            string query = "SELECT username FROM user WHERE username = @Username";
            MySqlDataReader dr = dbObj.ExecuteReader(query, ("@Username", user.Username));

            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("User already exists.");
                dbObj.cnClose();
                return;
            }
            dr.Close();

            string insertQuery = "INSERT INTO user (username, password, usertype) " +
                                 "VALUES (@Username, @Password, @Usertype)";
            dbObj.ExecuteNonQuery(insertQuery,
                ("@Username", user.Username),
                ("@Password", user.Password),
                ("@Usertype", user.Usertype));
            MessageBox.Show($"Registration successful as {user.Usertype}!");
            dbObj.cnClose();
        }
        
        public bool DoesUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM user WHERE username = @username";
            try
            {
                dbObj.cnOpen();
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.cn);
                cmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
                return false;
            }
            finally
            {
                dbObj.cnClose();
            }
        }
        public bool IsPasswordCorrect(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM user WHERE username = @username AND BINARY password = @password";
            try
            {
                dbObj.cnOpen();
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking password: " + ex.Message);
                return false;
            }
            finally
            {
                dbObj.cnClose();
            }
        }


        public DataTable login(string u, string p)
        {
            string selectQuery = "SELECT * FROM user WHERE username = @Username AND password = @Password";
            return dbObj.ExecuteQueryDataTable(selectQuery,
                ("@Username", u),
                ("@Password", p));
        }
    }
}