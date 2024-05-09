using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class Command 
    {
        //public Command(string[] id) { }

        public SqlServer server;
        public abstract List<string> Execute( string text);

    }
}
