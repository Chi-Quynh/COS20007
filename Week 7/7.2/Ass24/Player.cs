namespace Ass24
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;
        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {

            if (this.AreYou(id)) { return this; }
            else if (_location.Locate(id) != null) { return _location.Locate(id); }
            return this._inventory.Fetch(id);

        }

        public override string FullDescription
        {
            get
            {
                string fulldesc = $"You are {Name}, you are carrying\n{_inventory.ItemList}";
                return fulldesc;
            }
        }

        public Inventory Inventory { get { return _inventory; } }

        public Location Location { get { return _location;  } set { _location = value; } }
    }
}
