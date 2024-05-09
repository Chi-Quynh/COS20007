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

        public override List<string> Execute(Location loc, string name, string id1)
        {
            SqlServer server = new SqlServer();
            List<string> result;

            result = server.FindItems(loc, name, id1);
            if (result.Count() == 0)
            {
                result.Add("Unable to find item");
            }


            return result;

            }
            

    }
}
