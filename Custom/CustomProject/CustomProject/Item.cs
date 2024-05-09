using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class Item : ProgramObject
    {
        public Item(string[] idents, string name, string desc) : base(idents, name, desc)
        {
            foreach (var ident in idents)
            {
                this.AddIdentifier(ident);
            }
        }

 

    }
}
