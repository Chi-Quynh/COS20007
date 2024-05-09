using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24
{
    public class MoveCommand:Command
    {
        public MoveCommand() : base(new string[] { "move" })
        { }

        public override string Execute(Player p, string[] text)
        {
            string error = "Cannot execute command.";
            string _move;
            if (text[0].ToLower() == "move" || text[0].ToLower() == "go" || text[0].ToLower() == "leave" || text[0].ToLower() == "head") 
            { 
                switch(text.Length)
                {
                    case 1:
                        return "No destinantion";
                    case 2:
                        _move = text[1];
                        break;
                    case 3:
                        _move = text[2];
                        break;

                    default:
                        return error;
                }

                GameObject _path = p.Location.Locate(_move);
                if (_path != null)
                {
                    if (_path.GetType() != typeof(Path))
                    {
                        return "Could not find the " + _path.Name;
                    }
                    p.Move((Path)_path);
                    return "You have moved " + _move + " through a " + _path.Name + " to " + p.Location.Name;
                }
                return "Cannot execute because the path is null";   




            }
            else
                return "Invalid move command";
        }



    }
}
