using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace RealEstateAgentRegistration
{
    public class People
    {
        Database databasefunc1 = new Database();

        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string address;

        //constructor
        public People()
        {
        }

        public People(int ID, string FIRSTNAME, string LASTNAME, string PHONE, string EMAİL, string ADDRESS)
        {
            this.Id = ID;
            this.FirstName = FIRSTNAME;
            this.LastName = LASTNAME;
            this.Phone = PHONE;
            this.Email = EMAİL;
            this.Address = ADDRESS;

        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public DataTable getAllPeople(string people)
        {
            string tableName = people;

            MySqlCommand command = new MySqlCommand("SELECT * FROM`" + tableName + "`");

            return databasefunc1.getData(command);
        } 

        //insert a new person to database
        public Boolean insertPeople(string people, People people1)
        {

            string tableName = people;

            MySqlCommand command = new MySqlCommand("INSERT INTO `" + tableName + "`(`first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@fn,@ln,@ph,@em,@add)");


            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = people1.firstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = people1.lastName;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = people1.phone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = people1.email;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = people1.address;

            return databasefunc1.ExecQuery(command);

        }

        //update the selected person
        public Boolean updatePeople(string people, People people1)
        {
            string tableName = people;

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "UPDATE house_owner SET first_name=@fn, last_name=@ln, phone=@ph, email=@em, address=@add Where id=@id";

            command.Parameters.AddWithValue("@id", people1.id);
            command.Parameters.AddWithValue("@fn", people1.firstName);
            command.Parameters.AddWithValue("@ln", people1.lastName);
            command.Parameters.AddWithValue("@ph", people1.phone);
            command.Parameters.AddWithValue("@em", people1.email);
            command.Parameters.AddWithValue("@add", people1.address);

            return databasefunc1.ExecQuery(command);

        }

        //delete a selected person 
        public Boolean deletePeople(string people, int id)
        {
            string tableName = people;

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "DELETE FROM house_owner Where id=@id";

            command.Parameters.AddWithValue("@id", id);

            return databasefunc1.ExecQuery(command);

        }
    }
}
