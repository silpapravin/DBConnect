using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DBConnect
{
    class DBCars
    {
        public MySqlDataReader GetCars(MySqlConnection connection)
        {
            string sql = "SELECT * FROM car;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Exception found ", ex.Message);
            }
            return reader;
        }

        public void Update(MySqlConnection connection,string vehicleregno,string make,string enginesize,DateTime dateregistered, double rentalperday,int available)
        {
            string sql = "UPDATE car SET vehicleregno=@vehicleregno,make=@make,enginesize=@enginesize,dateregistered=@dateregistered,rentalperday=@rentalperday,available=@available where vehicleregno='GH376DRS';";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@vehicleregno", vehicleregno);
            cmd.Parameters.AddWithValue("@make", make);
            cmd.Parameters.AddWithValue("@enginesize", enginesize);
            cmd.Parameters.AddWithValue("@dateregistered", dateregistered);
            cmd.Parameters.AddWithValue("@rentalperday", rentalperday);
            cmd.Parameters.AddWithValue("@available", available);

            cmd.Prepare();
            cmd.ExecuteNonQuery();


        }

        public void Insert(MySqlConnection connection, string vehicleregno, string make, string enginesize, DateTime dateregistered, double rentalperday, int available)
        {
            //string sql = "INSERT INTO car VALUES(vehicleregno=@vehicleregno,make=@make,enginesize=@enginesize,dateregistered=@dateregistered,rentalperday=@rentalperday,available=@available);";
            string sql = "INSERT INTO car (vehicleregno,make,enginesize,dateregistered,rentalperday,available)VALUES(@vehicleregno,@make,@enginesize,@dateregistered,@rentalperday,@available);";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@vehicleregno", vehicleregno);
            cmd.Parameters.AddWithValue("@make", make);
            cmd.Parameters.AddWithValue("@enginesize", enginesize);
            cmd.Parameters.AddWithValue("@dateregistered", dateregistered);
            cmd.Parameters.AddWithValue("@rentalperday", rentalperday);
            cmd.Parameters.AddWithValue("@available", available);

            cmd.Prepare();
            cmd.ExecuteNonQuery();


        }

        public void delete(MySqlConnection connection,string vehicleregno)
        {
            string sql = "DELETE FROM car Where vehicleregno='AAAAAAAA'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }



    }
}
