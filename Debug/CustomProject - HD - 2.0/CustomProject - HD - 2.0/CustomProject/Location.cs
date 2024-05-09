using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Location : ProgramObject
    { 


        Inventory _inventory;
        int _location_key;

        public Location(string[] id, string name, string desc, int location_key) : base(id, name, desc)
        {
            _inventory = new Inventory();
            _location_key = location_key;

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

        public List<ProgramObject> Find(string itemid)
        {
            List<ProgramObject> list = new List<ProgramObject>();

            if (this.AreYou(itemid))
                list.Add(this);

            foreach (Item i in  _inventory.Items)
            {
                if (i.AreYou(itemid) == true)
                {
                    list.Add(i);
                }

            }
            return list;
            
        }


        public Inventory Inventory
        {
            get { return _inventory; }

        }

        public int GetKey { get { return _location_key; } }

        public bool HasKey(int key)
        {
            if (_location_key == key)
                return true;
            else
                return false;
        }
    }
}
