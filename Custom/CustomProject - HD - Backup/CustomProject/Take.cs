using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Take : SendForm
    {

        public Take()
        {


        }
        public override string Execute(string[] _id, string _name, string _desc, Location _location)
        {
            if (TakeAt(_location, _id, _name) != null)
                return $"Successfully retrieved {TakeAt(_location, _id, _name).Name} at {_location}";
            return $"Error, item cannot be found at {_location}, please check name, ids or location";
        }

        public Item TakeAt(Location loc, string[] id, string name)
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

        }

    }
}

