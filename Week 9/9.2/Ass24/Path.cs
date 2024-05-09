using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ass24
{
    public class Path: GameObject
    {
        private string _direction;

        Location _loc2;
        public Path(string direction, Location _loc1, Location loc2) :base(new string[] {direction},"Path","A Path")
        {
            _direction = direction;
            _loc2=loc2;


        }

        public string Direction
        {
            get { return _direction; }
        }

        public Location Destination
        {
            get { return _loc2; }
        }
    }

}
