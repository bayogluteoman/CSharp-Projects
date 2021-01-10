using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgentRegistration
{
    public class Property
    {
        Database databasefunc2 = new Database();

        private int idHouse;
        private int owner_Id; //int
        private string type;
        private string numOfRooms;
        private string floor;
        private string price;
        private string address;
        private int size; //string
        private string comment;
        private string image;

        //constructor
        public Property()
        {
        }

        public Property(int IDHOUSE, int OWNER_ID, string TYPE, string NUMOFROOMS, string FLOOR, string PRICE, string ADDRESS, int SIZE, string COMMENT,string IMAGE   )
        {
            this.IdHouse = IDHOUSE;
            this.Owner_Id = OWNER_ID;
            this.Type = TYPE;
            this.NumOfRooms = NUMOFROOMS;
            this.Price = PRICE;
            this.Floor = FLOOR;
            this.Address = ADDRESS;
            this.Size = SIZE;
            this.Comment = COMMENT;
            this.Image = IMAGE;

        } 

       public int Owner_Id { get => owner_Id; set => owner_Id = value; }
        public string Type { get => type; set => type = value; }
        public string NumOfRooms { get => numOfRooms; set => numOfRooms = value; }
        public string Price { get => price; set => price = value; }
        public string Address { get => address; set => address = value; }
        public int Size { get => size; set => size = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Floor { get => floor; set => floor = value; }
        public int IdHouse { get => idHouse; set => idHouse = value; }
        public string Image { get => image; set => image = value; }


        //get all properties
        public DataTable getAllProperty(string property)
        {
            string tableName = property;

            MySqlCommand command = new MySqlCommand("SELECT * FROM`" + tableName + "`");

            return databasefunc2.getData(command);
        }

        //return images of houses as a list
        public List<Property> ConvertDataTable<T>(DataTable dataTable)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `house` WHERE `id`=@id");
            DataTable imagetable = databasefunc2.getData(command);
            List<Property> imagelist = new List<Property>();

            for (int i = 0; i < imagetable.Rows.Count; i++)
            {
                Property property = new Property();
                property.Image = imagetable.Rows[i]["house_image"].ToString();
                imagelist.Add(property);
            }
            return imagelist;
        }


        //get all properties by id
        public DataTable getPropertyById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `house` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return databasefunc2.getData(command);
        }


        //insert a new property

        public Boolean insertHouse(Property property)
        {


            MySqlCommand command = new MySqlCommand("INSERT INTO `house`(`owner_id`, `type`, `room_no`, `house_floor`, `house_price`,`house_address`, `house_size`, `house_comment`) VALUES (@ownerId,@type,@roomNo,@floor,@price,@adrs,@size,@cmnt)");

            command.Parameters.Add("@ownerId", MySqlDbType.Int32).Value = property.owner_Id;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = property.type;
            command.Parameters.Add("@roomNo", MySqlDbType.VarChar).Value = property.numOfRooms;
            command.Parameters.Add("@floor", MySqlDbType.VarChar).Value = property.floor;
            command.Parameters.Add("@price", MySqlDbType.Double).Value = property.price;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = property.address;
            command.Parameters.AddWithValue("@size", property.size);
            command.Parameters.Add("@cmnt", MySqlDbType.VarChar).Value = property.comment;

            return databasefunc2.ExecQuery(command);

        }

        //update the selected property

        public Boolean updateHouse(Property property)
        {

            MySqlCommand command = new MySqlCommand();
            command.CommandText="UPDATE house SET owner_id=@ownerId, id=@id,type=@type, room_no=@roomNo, house_floor=@floor, house_price=@price, house_address=@adrs, house_size=@size, house_comment=@cmnt Where id=@id";

            command.Parameters.AddWithValue("@ownerId", property.owner_Id);
            command.Parameters.AddWithValue("@id", property.idHouse);
            command.Parameters.AddWithValue("@type", property.type);
            command.Parameters.AddWithValue("@roomNo", property.numOfRooms);
            command.Parameters.AddWithValue("@floor", property.floor);
            command.Parameters.AddWithValue("@price", property.price);
            command.Parameters.AddWithValue("@adrs", property.address);
            command.Parameters.AddWithValue("@size", property.size);
            command.Parameters.AddWithValue("@cmnt", property.comment);
           
            return databasefunc2.ExecQuery(command);

        }

        //delete the selected property

        public Boolean deleteHouse(int id)
        {

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM house Where id=@id";

            command.Parameters.AddWithValue("@id", id);
          
            return databasefunc2.ExecQuery(command);

        }
    }
}

