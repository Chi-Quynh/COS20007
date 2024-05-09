using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Post
    {
        private readonly Location location;
        
        private string[] _ids;
        private string _name;
        private string _desc;

        public Post(string[] ids, string name, string desc, Location location)
        {
            this.location = location;
            _ids = ids;
            _name = name;
            _desc = desc;
            
        }

        private string AddItemToInventory(string[] ids, string name, string desc)
        {

                Item itemToPost = new Item(ids, name, desc);

            if (itemToPost != null)
            {
            location.Inventory.Put(itemToPost);
            return "Item posted successfully";
            }

            return "Null item to post";

        }

        public string Execute
        {
            get
            {
                return AddItemToInventory(_ids, _name, _desc);
            }
        }
    }
}
