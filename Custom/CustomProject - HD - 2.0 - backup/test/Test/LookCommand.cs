using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class LookCommand : Command
    {

        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(LocationList loc, string[] text)
        {
            ProgramObject _obj;
            string _itemid;
            string error = "I don't know how to look like that";


            if (text[0].ToLower() != "look")
                return "Error in look input";



            switch (text.Length)
            {
                case 1:
                    return loc.List();
                    case 2:
                    return "Please specify the item you are looking.";

                case 3:
                    _itemid = text[2];
                    switch (text[1])
                        {
                        case "at":
                            _obj = LookAtFor(loc, _itemid);
                            if (_obj == null) return "Unable to find location";
                            return $"{_obj.FullDescription}";

                        case "for":
                            
                            _obj = LookAtFor(loc, _itemid);

                            if (_obj == null) return "Unable to find item";
                            return $"Found {_obj.Name}";
                        default:
                            return "Please specify your action.";

                    }
                default:
                    return error;
            }
            
        }


        //look for [item]
        /*public string LookFor(LocationList locations,string id)
        {
            

            foreach (Location a in locations.GetList)
            {
                if (a.Inventory.HasItem(id))
                {
                    return $"Found {a.Inventory.Fetch(id)} at {a.Name} ";
                }
            }
            return $"Unable to find item {id}";
        }

        //look at [location]
        public string LookAt(LocationList locations, string id)
        {
            

            foreach (Location a in locations.GetList)
            {
                if (a.AreYou(id))
                {
                    return $"Found {a.Name}\n{a.FullDescription}\n{a.ItemList}";
                }
            }
            return $"Unable to find location {id}";
        }*/

        public ProgramObject LookAtFor(LocationList locations, string id)
        {


            foreach (Location a in locations.GetList)
            {

                    return a.Locate(id);

            }
            return null;
        }
    }
}
