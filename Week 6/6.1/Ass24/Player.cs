using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ass24
{
    public class Player :GameObject, IHaveInventory
    {
        private Inventory _inventory;
        public Player (string name, string desc) :base(new string[] { "me", "inventory" },name,desc)
        {
            _inventory = new Inventory ();
        }

        public GameObject Locate(string id)
        {

            if (this.AreYou(id)) { return this; }

                return this._inventory.Fetch(id);

        }

        public override string FullDescription { get {
                string fulldesc = $"You are {Name}, you are carrying\n{_inventory.ItemList}";
                return fulldesc; } }

        public Inventory Inventory { get { return _inventory; } }
    }
}
