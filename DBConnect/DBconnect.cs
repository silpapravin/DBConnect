using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DBConnect
{
    class DBconnect
    {
        MySqlConnection connection = null;
        string connectionstring;

        public MySqlConnection Connection { get => connection;  }

        public DBconnect(string Servername, string Databasename, string Username,string Password)
        {
            this.connectionstring = string.Format($"SERVER={Servername};DATABASE={Databasename};UID={Username};PASSWORD={Password};");
        }
        public bool Connect()
        {
            bool suceed = true;
            try
            {
                this.connection = new MySqlConnection(this.connectionstring);
                this.connection.Open();
            }
            catch(MySqlException ex)
            {
                suceed = false;
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Authentication Error, cannot connect to the server");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid login credentials");
                        break;
                    default:
                        MessageBox.Show("Exception found",ex.Message);
                        break;

                }
            }
           
            
            return suceed;
        }
        public bool Close()
        {
            bool suceed = true;
            try
            {
                this.connection.Close();
            }
            catch (MySqlException ex)
            {
                suceed = false;
                MessageBox.Show("Exception found", ex.Message);
            }
            return suceed;
        }
    }
}
