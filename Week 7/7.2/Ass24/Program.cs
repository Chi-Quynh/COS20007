using System.Net.Http.Headers;

namespace Ass24
{
    public class Run
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter description");
            string desc = Console.ReadLine();
            Item item1 = new Item(new string[] { "white", "flower" }, "white flower", "a whiteflower");
            Item item2 = new Item(new string[] { "dark", "chocolate" }, "dark chocolate", "a darkchocolate");
            Player player = new Player(name, desc);
            player.Inventory.Put(item1);
            player.Inventory.Put(item2);
            Bag bag = new Bag(new string[] { "bagid1", "bagid2" }, name, desc);
            Item item3 = new Item(new string[] { "black", "spoon" }, "black spoon", "a blackspoon");
            bag.Inventory.Put(item3);
            player.Inventory.Put(bag);
            player.Location = new Location(new string[] { "blue", "lock" }, "Blue Lock", "a sports stadium");
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
                    LookCommand look = new LookCommand();
                    string[] words = input.Split(' ');
                    Console.WriteLine(look.Execute(player, words));
                }

            }


        }
    }
}
