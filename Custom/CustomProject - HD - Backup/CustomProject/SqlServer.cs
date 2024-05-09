using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 server = "feenix-mariadb.swin.edu.au";
            database = "s103805253_db";
            user = "s103805253";
            password = "s103805253";
            
            connectionString = $"server={server};user ={user}; database={database};password={password};";
 */

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace CustomProject
{
    public class SqlServer
    {
        private string connectionString = "server=feenix-mariadb.swin.edu.au;database=s103805253_db;user=s103805253;password=s103805253;";
        MySqlConnection connection;
        //LocationList list = new LocationList();
        public SqlServer() 
        { 
            connection = new MySqlConnection(connectionString);
        }


        /*public string Insert(Item item, Location location)
        {
            try
            {
                using (connection)
                {
                    connection.Open();


                    // Insert data into the Items table
                    //string insertQuery = $"INSERT INTO Items (name, description, location_id, item_id) VALUES ({item.Name}, {item.Description}, {location.FirstId}, {string.Join(',',item.IDs)})";
                    //MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    string selectQuery = $"INSERT INTO Items (name, description, location_id, item_id) VALUES (@name, @description, @location_key, @item_ids)";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@name", item.Name);
                    command.Parameters.AddWithValue("@description", item.Description);
                    command.Parameters.AddWithValue("@location_key", location.FirstId);
                    command.Parameters.AddWithValue("@item_ids", string.Join(',', item.IDs));

                    command.ExecuteNonQuery();
                    
                    return $"Item {item.Name} posted successfully\n{string.Join(',', item.IDs)}\n{item.Description} at {location.Name}";
                }
            }
            catch (Exception ex)
            {
                return "Error posting item: " + ex.Message;
            }
        }

        /*public string Remove(Location location, string name, string id)
        {
            try
            {
                using (connection)
                {
                    connection.Open();

                    switch (FindItems(location, name, id).Count())
                    {
                        case 0:
                            return "Could not find item to retrieve";
                        case 1:
                            string Itemid = "SELECT item_id FROM YourTableName WHERE
                            string deleteQuery = "DELETE FROM Items WHERE (',' + id_column + ',' LIKE @idPartial OR name = @name) AND location = @location LIMIT 1";
                            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@item_id", itemId);
                            int rowsAffected = command.ExecuteNonQuery();
                            return "Item removed successfully";
                        default:
                            return "More than 1 item found, please retry with more specific name and ids";
                    }

                }
            }
            catch (Exception ex)
            {
                return "Error removing item: " + ex.Message;
            }
        }*/

        public List<string> FindItems(Location location, string Findname, string id1)
        {

                List<string> foundItems = new List<string>();

                try
                {

                        connection.Open();

                        string itemids;
                        string name;
                        string desc;

                        string selectQuery = "SELECT * FROM Items WHERE item_id LIKE @id1 OR name = @Findname";
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        command.Parameters.AddWithValue("@Findname", Findname);
                        command.Parameters.AddWithValue("@id1", "%" + id1 + "%");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               
                                name = reader.GetString(1);
                                desc = reader.GetString(2);
                                foundItems.Add($"Item: {name}, {desc}. Found at {location.Name}");
                            }
                        }
                    
                }
                catch (Exception ex)
                {
                    throw new Exception( ex.Message);
                }

                return foundItems;
            

            /*List<string> foundItems = new List<string>();

            try
            {
                using (connection)
                {



                    //string selectQuery = $"SELECT * FROM Items WHERE name = '{Itemname}' OR item_id LIKE '%{id1}%';";
                    //string selectQuery = $"SELECT * FROM Items WHERE (item_id LIKE '%{id1}%') OR name = @itemname;";

                    connection.Open();

                    string itemids;
                    string name;
                    string desc;

                    string selectQuery = "SELECT * FROM Items WHERE (item_id LIKE @id1) OR name = @Findname AND location_key = ";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@itemname", Findname);
                    command.Parameters.AddWithValue("@id1", "%" + id1 + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itemids = reader.GetString(0);
                            name = reader.GetString(1);
                            desc = reader.GetString(2);
                            foundItems.Add($"Item: {name}, {desc}. Found at {location.Name}\nIds:{itemids}");
                        }
                    }

                    /*selectQuery = "SELECT * FROM Locations WHERE (location_id LIKE @id1) OR name = @locationname";
                    command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@name", Findname);
                    command.Parameters.AddWithValue("@id1", "%" + id1 + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader.GetString(1);
                            desc = reader.GetString(2);
                            foundItems.Add($"Location: {name}, {desc}. Ids: {string.Join(",",location.IDs)}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to find item duo to:" + ex.Message);
            }

            connection.Close();
            return foundItems;
*/
        }

        /*public LocationList CreateList()
        {
            


            try
            {
                using (connection)
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
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to find item duo to:" + ex.Message);
            }

            connection.Close();
            return list;
        }*/




    }
}

