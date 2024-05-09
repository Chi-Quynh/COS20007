using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Program2._4
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            for (int i = 0; i < idents.Length; i++)
            {
                _identifiers.Add(idents[i].ToLower());
            }

        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public bool AreYou(string id)
        {
            if (_identifiers.Contains(id.ToLower()))
                return true;
            return false;
        }


        public string FirstID
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers.First();

                }
            }
        }

    }
}