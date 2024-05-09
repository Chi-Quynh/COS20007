using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class Post :SendForm
    {


        //public Post() { }
         

        public override string Execute(SqlServer server, Item itemToPost, Location location)
        {
            

            
            //Null check for debugging
            if (itemToPost == null ) 
            {
                return "Error: Null item to post.";
            }
            else if (server == null)
            {
                return "Error: Null server.";
            }
            else if (location == null)
            {
                return "Error: Null location. ";
            }

            if (itemToPost.Name == "")
                return "Please enter your name";
            else if (location == null)
                return "Please select your location";
            else if (itemToPost.Description == "")
                return "Please enter your description";

            string result = server.Insert(itemToPost, location);

            if (result != null)
            {
                return result;
            }


            /*if (itemToPost != null)
            {
                location.Inventory.Put(itemToPost);
                return "Item posted successfully";
            }*/

            return "Item post failed";

        }
    }
}
