using System;
using System.Net.Http.Headers;

namespace Ass24
{
    public class Run
    {
        public static void Main(string[] args)
        {
            //Get info
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your description:");
            string desc = Console.ReadLine();

            Console.WriteLine($"You are {name},{desc}...");

            Player player = new Player(name, desc);
            
            Item item1 = new Item(new string[] { "white", "flower" }, "flower", "a whiteflower");
            Item item2 = new Item(new string[] { "dark", "chocolate" }, "chocolate", "a darkchocolate");

            player.Inventory.Put(item1);
            player.Inventory.Put(item2);
            Bag bag = new Bag(new string[] { "bagid1", "bagid2" }, name, desc);
            Item item3 = new Item(new string[] { "black", "spoon" }, "blackspoon", "a blackspoon");
            bag.Inventory.Put(item3);
            player.Inventory.Put(bag);
            
            Location _loc1 = new Location(new string[] { "location", "bluelock" }, "BlueLock", "a sports stadium");
            Location swin = new Location(new string[] { "location", "swinburne" }, "Swinburne", "a school");
            Location _loc3 = new Location(new string[] { "location", "graden" }, "Garden", "a garden");

            player.Location = swin;


            Path _path1 = new Path("out", _loc1, swin);
            Path _path2 = new Path("in", swin, _loc1);
            swin.AddPath(_path1);
            swin.AddPath(_path2);
            swin.Inventory.Put(item1);

            Console.WriteLine("Welcome to Swin Adventure! You have arrived in the Hallway Command");
            //Process
            string input;
            Command c = new CommandProcessor();
            //Console.WriteLine(c.Execute(player, new string[] { "look" }));

            while (true)
            {
                Console.Write("Enter command: ");
                input = Console.ReadLine();

                if (input.ToLower() != "quit")
                {
                    string[] inputArray = input.Split(' ');
                    Console.WriteLine(c.Execute(player, inputArray));
                }
                else
                {
                    Console.WriteLine("Bye");
                    Console.ReadKey();
                    break;
                }
            }


        }
    }
}
