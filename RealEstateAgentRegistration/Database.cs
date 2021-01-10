using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace RealEstateAgentRegistration
{
    class Database
    {
        dbConnection connection = new dbConnection();

        //insert
        public Boolean ExecQuery(MySqlCommand command)
        {
            command.Connection = connection.getConnection;

            //opened connection here
            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return true;
            }
        }

        //get data        
        public DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            
            return table;
        }
    }
}
