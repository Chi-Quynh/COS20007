using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] id) : base(id) { }


        public abstract string Execute(LocationList location, string[] text);

    }
}
