using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgentRegistration
{
    public class Realtor
    {
        Database dbfunc3 = new Database();

        private int realtor_Id;
        private string realtor_Firstname;
        private string realtor_Lastname;
        private string realtor_Username;
        private string realtor_Password;

        public int Realtor_ID { get => realtor_Id; set => realtor_Id = value; }

        public string Realtor_Firstname { get => realtor_Firstname; set => realtor_Firstname = value; }
        public string Realtor_Lastname { get => realtor_Lastname; set => realtor_Lastname = value; }
        public string Realtor_Username { get => realtor_Username; set => realtor_Username = value; }
        public string Realtor_Password { get => realtor_Password; set => realtor_Password = value; }

        public Realtor(int realtor_Id,string realtor_Firstname, string realtor_Lastname,string realtor_Username, string realtor_Password)
        {
            this.Realtor_ID = realtor_Id;
            this.Realtor_Firstname = realtor_Firstname;
            this.Realtor_Lastname = realtor_Lastname;
            this.Realtor_Username = realtor_Username;
            this.Realtor_Password = realtor_Password;
        }
        public Realtor(string realtor_Username, string realtor_Password)
        {
            this.Realtor_Username = realtor_Username;
            this.Realtor_Password = realtor_Password;
        }

        //constructor
        public Realtor()
        {
          
        }

        //insert user
        public Boolean insertUser(Realtor realtor)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `realtor`(`realtor_id`, `realtor_username`, `realtor_psswrd`, `realtor_firstname`, `realtor_lastname`)" +
                " VALUES (@id,@un,@pswd,@fn,@ln)");

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = realtor.realtor_Id;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = realtor.realtor_Username;
            command.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = realtor.realtor_Password;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = realtor.realtor_Firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = realtor.realtor_Lastname;

            return dbfunc3.ExecQuery(command);

        }
    }
}

