using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public interface ILocationList
    {
        public ProgramObject LocateItemorLoc(string id);

        public List<Location> GetList { get; }

        public string List();

        public void AddLocation(Location location);
    }
}
