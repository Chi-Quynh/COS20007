using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class LocationList :ILocationList
    {
        List<Location> locations;
        public LocationList()
        {
            locations = new List<Location>();
        }
        public void AddLocation(Location location)
        {
            locations.Add(location);
        }

        public List<Location> GetList { get { return locations;} }

        public int Count()
        { return locations.Count; }

        /*public ProgramObject LocateUsingLocorItemId(string id)
        {
           foreach (Location location in locations)
            {

                if (location.Locate(id) != null)
                {
                    return location.Locate(id);
                }
            }
            return null;
        }*/
        public ProgramObject LocateItemorLoc(string id)
        { 
            foreach (Location a in locations)
            {

                if (a.Locate(id) != null)
                    return a.Locate(id);
                //returns either location or item avaiable
            }
            return null;
        }
        public string List()
        {
            string output;
            if (Count() == 0)
            {
                output = "There are no locations yet";
            }
            else
            output = $"There are {Count()} locations in the school:\n";

            foreach ( Location a in locations){
                output += $"{a.FullDescription}";
            }
            return output;
        }



        }
}
