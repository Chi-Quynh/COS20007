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
            string error = "Error in look input.";

            /*if (text.Length != 3 || text.Length != 5 || text.Length != 1)
                return "I don’t know how to look like that";
            else
            {*/

                if (text[0].ToLower() != "look")
                    return "Error in look input";

                switch (text.Length)
                {
                    case 1:
                        _container = p;
                        _itemid = "swin";
                        break;
                    case 3:
                        if (text[1].ToLower() != "at")
                            return "What do you want to look at?";

                        _container = p;
                        _itemid = text[2];
                        break;

                    case 5:
                        if (text[1].ToLower() != "at")
                            return "What do you want to look at?";

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
