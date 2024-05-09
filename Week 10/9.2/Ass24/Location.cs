using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24
{
    public class Location :GameObject, IHaveInventory
    {
       
        private string _name;
        private string _desc;
        Inventory _inventory;
        List<Path> _paths;

        public Location(string[] id, string name, string desc) :base(id, name, desc)
        {
            _inventory = new Inventory();
            _name = name;
            _desc = desc;
            _paths = new List<Path>();
        }


        public GameObject Locate(string itemid) 
        {
            if (AreYou(itemid))
            {
                return this;
            }
            foreach (Path path in _paths) 
            { 
                if (path.Direction == itemid)
                { return path;}
            }
            return _inventory.Fetch(itemid);
        }

        public override string FullDescription
        {
            get { return $"You are at {_name}, {_desc}\n{ItemList}{PathList}"; }
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

        public string PathList
        {
            get
            {
                string result = "";

                    foreach (Path path in _paths)
                    {
                        result+= $"\nThere is a {path.Destination.Name} to the {path.Direction}";
                    }
                return result;
            }
        }


        public void AddPath(Path path)
        {
            _paths.Add(path);
        }


    }
}
