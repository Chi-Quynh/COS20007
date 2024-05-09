using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class LocationList : ILocationList
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

        public List<Location> GetList { get { return locations; } }

        /*public int Count()
        { return locations.Count; }

        /*public Item HasItem(string id)
        {
            foreach (Location a in locations)
            {

                if (a.Inventory.HasItem(id) == true)
                    return a.Inventory.Fetch(id);
                //returns item avaiable
            }
            return null;
        }*/

        
        public Location Locate(string id)
        {
            foreach (Location location in locations)
            {
                if (location.AreYou(id)) return location;   
            }
            return null;
        }
        public Location HasKey(int key)
        {
            foreach (Location a in locations)
            {

                if (a.HasKey(key) == true)
                    return a;
                //returns item avaiable
            }
            return null;
        }


        /*public void SaveItemsToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Count());
                foreach (Location loc in locations)
                {
                    writer.WriteLine(loc.Name);
                    writer.WriteLine(loc.Description);
                    writer.WriteLine(string.Join(",", loc.Id));
                    writer.WriteLine(loc.Inventory.Count);
                    foreach (var item in loc.Inventory.Items)
                    {
                        writer.WriteLine($"{item.IDs}");
                        writer.WriteLine($"{item.Name}");
                        writer.WriteLine($"{item.Description}");
                    }
                }

            }
        }

        public void LoadItemsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                locations.Clear(); // Clear existing items before loading from file
                using (StreamReader reader = new StreamReader(filePath))
                {

                    int locationcount = int.Parse(reader.ReadLine());
                    while (locationcount > 0)
                    {
                        string locname = reader.ReadLine();
                        string locdesc = reader.ReadLine();
                        string locid = reader.ReadLine();
                        int itemcount = int.Parse(reader.ReadLine());
                        while (itemcount > 0)
                        {
                            string[] id = reader.ReadLine().Split(' ');
                            string name = reader.ReadLine();
                            string description = reader.ReadLine();
                            
                        }
                        locationcount --;
                    }
                    while (() != null)
                    {
                        string[] parts = line.Split(',');


                        string[] id = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        _inventory.Put(new Item(id, name, description));

                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
        }*/
            
    }
}
    
