using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public interface ILocationList
    {
        public Location HasItem(string id);

        public Location Locate(string id);

        public List<Location> GetList { get; }

        public void AddLocation(Location location);

        
    }
}
