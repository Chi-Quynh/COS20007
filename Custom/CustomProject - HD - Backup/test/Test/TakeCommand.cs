using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class TakeCommand : Command
    {

        public TakeCommand() : base(new string[] { "take" })
        {
        }
        public override string Execute(LocationList loc, string[] text)
        {
            if (text[0] != "take")
                return "Invalid take command";
            //Takes
            return null;
        }
    }
}
