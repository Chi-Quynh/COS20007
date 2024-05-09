using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class PostCommand : Command
    {

        public PostCommand() : base(new string[] { "post" })
        {
        }
        public override string Execute(LocationList loc, string[] text)
        {
            if (text[0] != "post")
                return "Invalid post command";
            return null;
        }
    }
}