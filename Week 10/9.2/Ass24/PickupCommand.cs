using Ass24;
using System;
using System.ComponentModel;

namespace Ass24
{
    public class PickupCommand : Command
    {
        public PickupCommand() : base(new string[] { "pickup", "take" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            Location _container;

            string _itemid;
            string error = "I don't know how to pickup/take like that";

            if (text[0] != "take" && text[0] != "pickup")
                return "Error in take/pickup.";

            switch (text.Length)
            {
                case 1:
                    error = "Take/Pickup what?";
                    return error;
                case 2:
                    _itemid = text[1];
                    _container = p.Location;

                    if (_container.Inventory.HasItem(text[1]) == false)
                    {
                        return $"Location does not posess {text[1]} to put into desired location";
                    }
                    break;

                case 4:
                    if (text[2] != "at")
                        return "Where do you want to pickup/take?";

                    _container = Fetch(p, text[3]);


                    if (_container == null)
                        return "Could not find " + text[3];

                    _itemid = text[1];

                    if (_container.Inventory.HasItem(text[1]) == false)
                    {
                        return $"Location does not posess {text[1]} to put into desired location";
                    }
                    break;
                default:
                    return error;
            }
            return PickupAt(_itemid, _container);
        }

        private string PickupAt(string itemid, Location location)
        {

            if (itemid != null)
            {

                location.Inventory.Take(itemid);

                return $"Sucess put {itemid} in {location.Name}";
            }




            return "Invalid item (null), please try again";
        }

        private Location Fetch(Player player, string containerId)
        {
            return player.Locate(containerId) as Location;
        }

    }
}
