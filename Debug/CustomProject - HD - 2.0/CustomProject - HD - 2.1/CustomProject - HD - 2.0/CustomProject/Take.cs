using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace CustomProject
{
    public class Take : SendForm
    {

        public Take()
        {


        }
        public override string Execute(SqlServer server, Item item, Location _location)
        {
            if (item == null)
            {
                return "Error: Null item to post.";
            }
            else if (server == null)
            {
                return "Error: Null server.";
            }
            else if (_location == null)
            {
                return "Error: Null location. ";
            }

            if (item.Name == "")
                return "Please enter your name";
            else if (_location == null)
                return "Please select your location";
            else if (item.Description == "")
                return "Please enter your description";

            string result = server.Remove(_location, item.Name, item.Description);

            if (result != null)
            {
                return result;
            }
            /*if (TakeAt(_location, item.IDs, item.Name) != null)
                return $"Successfully retrieved {TakeAt(_location, item.IDs, item.Name).Name} at {_location}";*/
            return $"Error, item cannot be found at {_location}, please check name, description and location";
        }

        /*public Item TakeAt(Location loc, string[] id, string name)
        {
            //Location a = locations.LocateLocation(id);wedont need this, this is finding location based on the id of the item

                foreach (string b in id)
                {
                    if (loc.Inventory.HasItem(b) == true)
                    {
                        return loc.Inventory.Take(b);
                    }

                }

                if (loc.Inventory.HasItem(name) == true)
                return loc.Inventory.Take(name);

            return null;

        }*/

    }
}

