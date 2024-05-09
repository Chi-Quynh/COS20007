using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

/*
 server = "feenix-mariadb.swin.edu.au";
            database = "s103805253_db";
            user = "s103805253";
            password = "s103805253";
            
            connectionString = $"server={server};user ={user}; database={database};password={password};";
 */

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using NUnit.Framework.Internal;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace CustomProject
{
    public class SqlServer
    {
        private string connectionString = "server=feenix-mariadb.swin.edu.au;database=s103805253_db;user=s103805253;password=s103805253;";
        MySqlConnection connection;
        LocationList list = new LocationList();
        public SqlServer() 
        { 
            connection = new MySqlConnection(connectionString);
        }


        public string Insert(Item item, Location location)
        {
            try
            {
                connection.Open();

               

                string selectQuery = "INSERT INTO Items (name, description, location_code, item_id) VALUES (@name, @description, @location_key, @item_ids)";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@name", item.Name);
                    command.Parameters.AddWithValue("@description", item.Description);
                    command.Parameters.AddWithValue("@location_key", location.GetKey);
                    command.Parameters.AddWithValue("@item_ids", string.Join(',', item.IDs));

                    command.ExecuteNonQuery();
                    connection.Close();
                    return $"Item '{item.Name}' posted successfully at '{location.Name}'. Description: {item.Description}.\nIds: '{string.Join(',', item.IDs)}'.";

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                    return "Duplicate item. Please re-enter.";
                throw new Exception( ex.Message);
            }
        }

        /*public string Remove(Location location, string name, string desc)
        {
            try
            {


                //List<string> items = FindItems(location, name, id, desc);

                connection.Open();
                            
                            string deleteQuery = "DELETE FROM Items WHERE description = '@desc' AND name = '@name'";
                           MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@desc", desc);
                            command.Parameters.AddWithValue("@name", name);
                            
                            int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    return "Item retrieved successfully";
                }
                else 
                {
                    return "Failed to find item for retrival.";
                }
               




            }
            catch (Exception ex)
            {
                return "Error removing item: " + ex.Message;
            }

        }*/

        public string Remove(Location location, string name, string desc)
        {
            try
            {

                connection.Open();
                string deletequery = "DELETE FROM Items WHERE name = @name AND description = @desc;";
                MySqlCommand command = new MySqlCommand(deletequery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@desc", desc);
                int Rowsaffected = command.ExecuteNonQuery();
                connection.Close();

                if (Rowsaffected > 0)
                {
                    return "Item retrieved successfully";
                }
                else
                {
                    return "Failed to find item for removal.";
                }

            }
            catch (Exception ex)
            {
                return "Error removing item: " + ex.Message;
            }
        }


            //FIND ITEM - Do not touch

            public List<string> FindItems(string text)
        {

            List<string> foundItems = new List<string>();

            
            

            try
            {
                LocationList locationList = GetList();

                connection.Open();

                string itemids;
                string name;
                string desc;
                int code;
                string locationame = "can't be found";

                string selectQuery = "SELECT * FROM Items WHERE item_id LIKE @id1 OR name = @Findname OR description LIKE @description";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Findname", text);
                command.Parameters.AddWithValue("@id1", "%" + text + "%");
                command.Parameters.AddWithValue("@description", "%" + text + "%");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemids = reader.GetString(0);
                        name = reader.GetString(1);
                        desc = reader.GetString(2);
                        code = reader.GetInt32(3);

                        locationame = locationList.HasKey(code).Name;

                        foundItems.Add($"Item: {name}.Desc: {desc}. Location: {locationame}. Ids: {itemids}");
                    }
                }


                FindLocation(foundItems, text);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //returns and closes
            connection.Close();
            return foundItems;
        }




        public void FindLocation(List<string> list, string text)
        {


            try
            {

                string locids;
                string name;
                string desc;

                string selectQuery = "SELECT * FROM Locations WHERE location_id LIKE @id1 OR name = @Findname";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Findname", text);
                command.Parameters.AddWithValue("@id1", "%" + text + "%");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        locids = reader.GetString(1);
                        name = reader.GetString(2);
                        desc = reader.GetString(3);
                        list.Add($"Location: {name}. Desc: {desc}. Ids: {locids}");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }


    

    public LocationList GetList()
    {



        try
        {

                int location_key;
                string name;
                string desc;
                string[] location_ids;
                Location newloc;




                //string selectQuery = $"SELECT * FROM Items WHERE name = '{Itemname}' OR item_id LIKE '%{id1}%';";
                //string selectQuery = $"SELECT * FROM Items WHERE (item_id LIKE '%{id1}%') OR name = @itemname;";

                connection.Open();


                string selectQuery = "SELECT * FROM Locations";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        location_key = reader.GetInt32(0);
                        location_ids = reader.GetString(1).Split(',');
                        name = reader.GetString(2);
                        desc = reader.GetString(3);

                        newloc = new Location(location_ids, name, desc, location_key);
                        list.AddLocation(newloc);
                    }
                }
            
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        connection.Close();
        return list;
        }
    }



}


