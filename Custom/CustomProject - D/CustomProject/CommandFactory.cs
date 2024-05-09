using NUnit.Framework.Internal.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class CommandFactory
    {
        public Command makeCommand(string[] text)
        {
            //Command command = null;
            if (text[0] == "look")
                return new LookCommand();
            else if (text[0] == "take" )
                return new TakeCommand();
            else
                return null;
        }
    }
}
