namespace Ass24
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory;
        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            else if (this.AreYou(id))
            {
                return this;
            }
            return null;
        }

        public override string FullDescription
        {
            get
            {

                return $"In the {Name} you can see:{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }


        }
    }
}
