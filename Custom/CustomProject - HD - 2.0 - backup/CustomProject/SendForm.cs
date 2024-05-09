using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class SendForm :SqlServer
    {
        
        public SendForm() { }
        public abstract string Execute(SqlServer server, Item item , Location location);
    }
}
