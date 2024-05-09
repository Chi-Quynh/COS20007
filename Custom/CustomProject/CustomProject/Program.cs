using CustomProject;
using System;
using System.Net.Http.Headers;
using System.Numerics;

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
            User user = new User(name, desc);

            Item item1 = new Item(new string[] { "white", "flower" }, "flower", "a whiteflower");
            Item item2 = new Item(new string[] { "dark", "chocolate" }, "chocolate", "a darkchocolate");


            Item item3 = new Item(new string[] { "black", "spoon" }, "blackspoon", "a blackspoon");


            Location _loc1 = new Location(new string[] { "location", "bluelock" }, "BlueLock", "a sports stadium");
            Location swin = new Location(new string[] { "location", "swinburne" }, "Swinburne", "a school");
            Location _loc3 = new Location(new string[] { "location", "graden" }, "Garden", "a garden");


            swin.Inventory.Put(item1);
            swin.Inventory.Put(item2);


            swin.Inventory.Put(item1);

            Console.WriteLine("Welcome to Swin Adventure! You have arrived in the Hallway Command");
            //Process
            string input;
            /*Command c = new CommandProcessor();
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
            }*/


        }
    }
}

