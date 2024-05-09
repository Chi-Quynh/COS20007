using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24
{
    public class PutCommand : Command
    {
        public PutCommand() : base(new string[] { "put", "drop" })
        {

        }

        public override string Execute(Player p, string[] text)
        {

            Location _container;

            Item _itemid;
            string error = "I don't know how to put/drop like that";

            



            if (text[0] != "put" && text[0] != "drop")
                return "Error in put/drop.";

            switch (text.Length)
            {
                case 1:
                    error = "Put/Drop what?";
                    return error;
                case 2:

                    if (p.Inventory.HasItem(text[1]) == false)
                    {
                        return $"Player does not posess {text[1]} to put into desired location";
                    }

                    _itemid = p.Inventory.Take(text[1]);
                    _container = p.Location;
                    break;

                case 4:

                    if (p.Inventory.HasItem(text[1]) == false)
                    {
                        return $"Player does not posess {text[1]} to put into desired location";
                    }



                    if (text[2] != "at")
                        return "Where do you want to put/drop?";

                    _container = Fetch(p, text[3]);


                    if (_container == null)
                        return "Could not find " + text[3];

                    _itemid = p.Inventory.Take(text[1]);

                    break;
                default:
                    return error;
            }
            return PutAt(_itemid, _container);
        }

        private string PutAt(Item item, Location location)
        {
            if (item != null)
            {
                
                location.Inventory.Put(item);
               
                return $"Sucess put {item.Name} in {location.Name}";
            }




            return "Invalid item (null), please try again";
        }

        private Location Fetch(Player player, string containerId)
        {
            return player.Locate(containerId) as Location;
        }


    }
}
