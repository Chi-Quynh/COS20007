using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomProject
{
    public class User : ProgramObject
    {

        public User(string name, string desc) : base(new string[] { "student" }, name, desc)
        {

        }

        public override string FullDescription
        {
            get
            {
                string fulldesc = $"You are {Name}";
                return fulldesc;
            }
        }


    }

}
