namespace Ass24
{
    public class Inventory
    {
        private List<Item> _items;
        public Inventory()
        {
            _items = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                    return true;
            }
            return false;
        }

        public void Put(Item itm) { _items.Add(itm); }
        public Item Take(string id)
        {

            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                    _items.Remove(item);
                return item;
            }

            return null;
        }

        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                    return item;
            }

            return null;
        }

        public string ItemList
        {
            get
            {
                string result = "There is:";

                if (_items.Count == 0)
                    return "There is no item here";

                foreach (Item item in _items)
                {
                    result += $"\n{item.ShortDescription}";
                }

                return result;
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }


    }
}
