using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24 
{
    
    public class Map : IHaveInventory
    {
        private List<Location> locations;
        public Map()
        {
            locations = new List<Location>();
        }

        public GameObject Locate(string id)
        {
            foreach (Location location in locations) 
            {
                if (location.AreYou(id) != null)
                {
                    return location;
                }
            }
            return null;
        }


        public string Name { get; }

        public void AddLocation(Location loc) { locations.Add(loc); }
    }
}
