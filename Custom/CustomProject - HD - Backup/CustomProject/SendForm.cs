using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class SendForm :SqlServer
    {
       
        public abstract string Execute(string[] ids, string name, string desc, Location location);
    }
}
