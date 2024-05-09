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
        public Command makeCommand(string text)
        {
            //Command command = null;
            if (text == "look")
                return new LookCommand();

                return null;
        }
    }
}
