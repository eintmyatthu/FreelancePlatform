using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FreelancePlatform.Class
{
    internal class DataConnection
    {
        public static MySqlConnection cn;
        public static string connectionString = "server=localhost;uid=root;pwd=1997;database=freelancer_platform";

        public static MySqlConnection dataSource()
        {
            cn = new MySqlConnection(connectionString);
            return cn;
        }

        public void cnOpen()
        {
            try
            {
                dataSource();
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        public void cnClose()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public void executeQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader dataReader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cn);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader ExecuteReader(string query, params (string, object)[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query, cn);
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Item1, param.Item2);
            }
            try
            {
                cnOpen();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                cnClose();
                throw new Exception("Error executing reader: " + ex.Message);
            }
        }

        public DataTable ExecuteQueryDataTable(string query, params (string, object)[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Item1, param.Item2);
                    }
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public int ExecuteNonQuery(string query, params (string, object)[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Item1, param.Item2);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object showDataGridView(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.Connection = dataSource();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            return bindingSource;
        }
    }
}