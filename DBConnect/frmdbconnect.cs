using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBConnect
{
    public partial class frmdbconnect : Form
    {
        DBconnect db = null;
        public frmdbconnect()
        {
            InitializeComponent();
        }

        private void buttonclick_Click(object sender, EventArgs e)
        {
            this.db = new DBconnect("localhost", "hire", "csharp", "password");
            if(db.Connect())
            {
                MessageBox.Show("Connected to MySql server");
            }
            //db.Close();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            DBCars dbcars = new DBCars();
            DateTime dateregistered = new DateTime(2007, 04, 13);
            dbcars.Update(this.db.Connection, "GH376DRS", "Ford", "1.6L", dateregistered, 90, 1);
            MessageBox.Show("Record Updated");
        }

        private void frmdbconnect_Load(object sender, EventArgs e)
        {
            

        }

        private void buttongetcars_Click(object sender, EventArgs e)
        {
            string carmessage = string.Empty;
            DBCars dbcars = new DBCars();
            MySqlDataReader reader = dbcars.GetCars(this.db.Connection);
            while (reader.Read())
            {
                string vehicleregno = reader.GetString(0);
                string make = reader.GetString(1);
                string enginesize = reader.GetString(2);
                DateTime dateregistered = reader.GetDateTime(3);
                double rentalperday = reader.GetDouble(4);
                int available = reader.GetInt32(5);

                 carmessage += string.Format($"Vehicle Registration={vehicleregno},Make={make},EngineSize={enginesize},Date Registered={dateregistered},Rental={rentalperday},Available={available}");

                MessageBox.Show(carmessage);
            }
            reader.Close();
        }

        private void frmconnect_frmclosing(object sender, FormClosingEventArgs e)
        {
           if(this.db!=null)
            {
                this.db.Close();
            }
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            DBCars dbcars = new DBCars();
            DateTime dateregistered = new DateTime(2007, 06, 23);
            dbcars.Insert(this.db.Connection, "AAAAAAAA", "Ford", "1.6L", dateregistered, 90, 1);
            MessageBox.Show("Record inserted");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DBCars dbcars = new DBCars();
            dbcars.delete(this.db.Connection, "AAAAAAAA");
            MessageBox.Show("Record deleted");
                    }
    }
}
