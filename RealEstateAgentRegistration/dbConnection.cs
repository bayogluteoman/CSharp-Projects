using MySql.Data.MySqlClient;
using System.Data;

namespace RealEstateAgentRegistration
{
    public class dbConnection
    {
        static string server = "localhost";
        static string database = "test";
        static string uid = "root";
        static string password = "12345";
        public static string strProvider = "server=" + server + ";Database=" + database + ";User ID=" + uid + ";Password=" + password;

        MySqlConnection connection = new MySqlConnection(strProvider);

        // get connection here
        public MySqlConnection getConnection { get => connection; set => connection = value; }

        //open connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}