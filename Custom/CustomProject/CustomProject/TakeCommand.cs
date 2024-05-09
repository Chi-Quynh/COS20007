using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class TakeCommand : Command
    {

        public TakeCommand() : base(new string[] { "take" })
        {
        }
        public override string Execute(LocationList loc, string[] text)
        {

            string itemid;
            string locationid;
            if (text[0] != "take")
                return "Invalid take command";

            switch (text.Length)
            {
                case 1:
                    return "Take where?";
                case 2:
                    itemid = text[1];
                    locationid = TakenAt(loc, itemid).Name;

                    if (loc.LocateItemorLoc(itemid) == null)
                        return $"Cannot find item {itemid}.";

                    break;
                case 4:
                    itemid = text[1];
                    locationid = text[3];
                    if (text[2] != "at")
                        return "Invalid take command";

                    if (loc.LocateItemorLoc(locationid) == null)
                        return $"Cannot find location {text[3]}.";

                    if (loc.LocateItemorLoc(itemid) == null)
                        return $"Cannot find item at location {text[3]}.";
                    break;

                default:
                    return "Invalid take command";
            }
            Item taken = TakeAt(loc, itemid);
            if (taken == null)
                return null;

            return $"Taken {taken.Name} at {locationid}";
        }


        public Item TakeAt(LocationList locations, string id)
        {
            //Location a = locations.LocateLocation(id);wedont need this, this is finding location based on the id of the item

            foreach (Location a in locations.GetList)
            {
                if (a.Locate(id) != null)
                    return a.Inventory.Take(id);

            }
            return null;

        }

        public Location TakenAt(LocationList locations, string itemid)
        {
            foreach (Location a in locations.GetList)
            {
                if (a.Inventory.HasItem(itemid) != null)
                    return a;
            }
            return null;
        }
    }
}
