using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class LookCommand : Command
    {

        public LookCommand()// : base(new string[] { "look" })
        {
        }

        public override List<string> Execute(Location loc, string text)
        {
            SqlServer server = new SqlServer();
            List<string> result;

            result = server.FindItems(text);
            if (result.Count() == 0)
            {
                result.Add("Unable to find item");
            }


            return result;

            }
            

    }
}
