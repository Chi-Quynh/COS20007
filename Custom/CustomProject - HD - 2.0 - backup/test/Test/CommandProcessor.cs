using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject
{
    public class CommandProcessor : Command
    {
        List<Command> _commands;

        public CommandProcessor() : base(new string[] { "command" })
        {
            _commands = new List<Command>();
            _commands.Add(new LookCommand());

            /*_commands.Add(new MoveCommand());
            _commands.Add(new PickupCommand());*/
        }

        public override string Execute(LocationList loc, string[] text)
        {
            foreach (Command cmd in _commands)
            {
                if (cmd.AreYou(text[0].ToLower()))
                {
                    return cmd.Execute(loc, text);
                }
            }
            return $"I don't understand {string.Join("", text)}";

        }
    }
}
