using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Location : ProgramObject
    { 

        private string _name;
        private string _desc;
        Inventory _inventory;
        

        public Location(string[] id, string name, string desc) : base(id, name, desc)
        {
            _inventory = new Inventory();
            _name = name;
            _desc = desc;
        }

        //This returns location or item
        public ProgramObject Locate(string itemid)
        {
            if (AreYou(itemid))
            {
                return this;
            }
            return _inventory.Fetch(itemid);
        }

        public override string FullDescription
        {
            get { return $"{_name}, {_desc}. {ItemList}"; }
        }
        public Inventory Inventory
        {
            get { return _inventory; }

        }

        public string ItemList
        {
            get
            {
                if (_inventory.Count == 0)
                {
                    return "There is no item at the location";
                }
                return "At the location you see:\n" + Inventory.ItemList;
            }
        }

    }
}
