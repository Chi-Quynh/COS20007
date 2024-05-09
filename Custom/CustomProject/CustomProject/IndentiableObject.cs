﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();
        public IdentifiableObject(string[] indents)
        {
            foreach (var ident in indents) { _identifiers.Add(ident); }

        }

        public bool AreYou(string id)
        {
            if (_identifiers.Contains(id))
            {
                return true;
            }
            return false;
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                    return "";
                return _identifiers[0];
            }
        }



        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }

}
