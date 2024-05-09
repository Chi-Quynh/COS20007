using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public abstract class ProgramObject : IdentifiableObject
    {
        private string _description;
        private string _name;

        public ProgramObject(string[] id, string name, string desc) : base(id)
        {
            _description = desc;
            _name = name;
        }
        public string Name { get { return _name; } }
        public string ShortDescription
        {
            get
            {
                string _shortdesc = _name + " " + "(" + FirstId + ")";
                return _shortdesc;
            }
        } //name and FirstId
        public virtual string FullDescription { get { return _description; } }
    }
}
