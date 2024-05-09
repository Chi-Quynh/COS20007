using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Post 
    {
        
        public Post(string[] ids, string name, string desc,  Location location) 
        {
            Item newitem = new Item(ids, name, desc);
            location.Inventory.Put(newitem);
        }

    }
}
