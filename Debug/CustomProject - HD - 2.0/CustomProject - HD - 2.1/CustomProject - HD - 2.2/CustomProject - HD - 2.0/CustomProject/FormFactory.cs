using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class FormFactory  
    {
        public SendForm MakeForm(string type) {
            if (type == "post")
                return new Post();
            else if (type == "retrieve")
                return new Take();
            else
                return null;
        }
    }
}
