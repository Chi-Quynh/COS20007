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
        private string[] _id;


        public ProgramObject(string[] id, string name, string desc) : base(id)
        {
            _description = desc;
            _name = name;
            _id = id;
        }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public string FirstId
        {
            get
            {
                if (_id.Length >0) return _id[0];
                return null;
           }
        }


        public bool AreYou(string id)
        {
            if (_id.Contains(id))
            {
                return true;
            }

            if (_name == id)
                return true;
            return false;
        }

        public string[] IDs { get { return _id; } }
    }
}
