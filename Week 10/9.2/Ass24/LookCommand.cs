namespace Ass24
{
    public class LookCommand : Command
    {

        public LookCommand() : base(new string[] { "look" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory _container;
            string _itemid;
            string error = "I don't know how to look like that";


                if (text[0].ToLower() != "look")
                    return "Error in look input";



                switch (text.Length)
                {
                case 1:
                    _container = p;
                    _itemid = "location";
                    break;
                case 3:

                        _container = p;
                        _itemid = text[2];
                        break;

                    case 5:

                        if (text[3] != "in")
                            return "What do you want to look in?";

                        _container = Fetch(p, text[4]);
                        if (_container == null)
                            return "Could not find " + text[4];
                        _itemid = text[2];
                        break;



                    default:
                        return error;
                }
                return LookAtIn(_itemid, _container);
            







        }

        private IHaveInventory Fetch(Player player, string containerId)
        {
            return player.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
                return container.Locate(thingId).FullDescription;

            return "Couldn't find " + thingId;
        }
    }
}
