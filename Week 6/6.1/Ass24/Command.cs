using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] id) : base(id) { }


        public abstract string Execute(Player p, string[] text);

    }
}
