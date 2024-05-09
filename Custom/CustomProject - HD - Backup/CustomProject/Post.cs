using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Post :SendForm
    {


        public Post()
        {

            
        }
         

        public override string Execute(string[] ids, string name, string desc, Location location)
        {


            Item itemToPost = new Item(ids, name, desc);

            if (itemToPost != null)
            {
                location.Inventory.Put(itemToPost);
                return "Item posted successfully";
            }

            return "Null item to post";

        }
    }
}
