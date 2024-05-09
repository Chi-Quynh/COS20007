using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
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

        public void Put(Item itm) {
            if (itm == null)
            {
                throw new Exception("Item is null");
            }
            _items.Add(itm); 
        }
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


        public int Count
        {
            get { return _items.Count; }
        }

        public List<Item> Items { get { return _items; } }  


    }
}
