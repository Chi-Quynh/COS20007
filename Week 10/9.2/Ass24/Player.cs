namespace Ass24
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;
        private Map _map;
        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            _map = new Map();
        }

        public GameObject Locate(string id)
        {

            if (this.AreYou(id)) { return this; }
            else if (_location.Locate(id) != null) { return _location.Locate(id); }
            else if (_map.Locate(id) != null) { return _map.Locate(id); }
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

        public Map Map { get { return _map; } }

        public Location Location { get { return _location;  } set { _location = value; } }

        public void Move(Path path)
        {
            if (path.Destination != null)
            {
                _location = path.Destination;
            }
        }

        
    }
}
