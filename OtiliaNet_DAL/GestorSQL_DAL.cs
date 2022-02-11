using MySql.Data.MySqlClient;
using OtiliaNet.OtiliaNet_ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtiliaNet.OtiliaNet_DAL
{
    public class GestorSQL_DAL
    {
        ClienteMySQL_ENT clientMySQL = new ClienteMySQL_ENT();
        string _query;
        DataTable _dt = new DataTable();
        public DataTable DataTable_FromQuery_WithMySQL(string queryIn)
        {
            clientMySQL.dataBase = "otilia";
            clientMySQL.serverName = "localhost";
            clientMySQL.serverPort = "3306";
            clientMySQL.userName = "root";
            clientMySQL.serverPwd = "";

            _query = queryIn;
            MySqlConnection connectionDB = new MySqlConnection(clientMySQL.ConnectionString());

            try
            {
                MySqlCommand cmd = new MySqlCommand(_query, connectionDB);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(_query, connectionDB);
                returnVal.Fill(_dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error MySQL: " + ex.Message);
            }
            finally
            {
                connectionDB.Close();
            }

            return _dt;
        }

        internal DataTable DataTable_FromQuery_WithSQLServer(string query)
        {
            DataTable dtOut = new DataTable();

            string connetionString;
            SqlConnection conn;
            SqlCommand command;

            try
            {

                connetionString = @"Data Source=PC-DAVID;Initial Catalog=db_otilia_tests;User ID=sa;Password=ViDa@3467";
                conn = new SqlConnection(connetionString);
                command = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(command);
                // this will query your database and return the result to your datatable
                da.Fill(dtOut);
                conn.Close();
                da.Dispose();

            }
            catch (Exception ex) { MessageBox.Show("Error SQL Server: " + ex.Message); }
            return dtOut;



        }

        public void TestConnectionWithSqlServer()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=PC-DAVID;Initial Catalog=db_test;User ID=sa;Password=ViDa@3467";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }


}
