using System.Net.Http.Headers;

namespace Ass24
{
    public class Run
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            string desc = $"I am {name}";
            Player player = new Player(name, desc);
            /*
            Item item1 = new Item(new string[] { "white", "flower" }, "white flower", "a whiteflower");
            Item item2 = new Item(new string[] { "dark", "chocolate" }, "dark chocolate", "a darkchocolate");

            player.Inventory.Put(item1);
            player.Inventory.Put(item2);
            Bag bag = new Bag(new string[] { "bagid1", "bagid2" }, name, desc);
            Item item3 = new Item(new string[] { "black", "spoon" }, "black spoon", "a blackspoon");
            bag.Inventory.Put(item3);
            player.Inventory.Put(bag);
            */
            Location _loc1 = new Location(new string[] { "blue", "lock" }, "Blue Lock", "a sports stadium");
            player.Location = _loc1;
            Location _loc2 = new Location(new string[] { "swin", "burne" }, "Swinburne", "a school");
            Path _path = new Path("North", _loc1, _loc2);
            player.Location.AddPath(_path);
            string input = "";
            Console.WriteLine("Write what you are looking for. To exit, type 'e' ");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "e")
                {
                    break;
                }
                else
                {
                    MoveCommand look = new MoveCommand();
                    string[] words = input.Split(' ');
                    Console.WriteLine(look.Execute(player, words));
                }

            }


        }
    }
}
