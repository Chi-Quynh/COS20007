using System.Numerics;
using Ass24;

namespace PutCommandTest
{
    public class Tests
    {

        Location _location1;
        Location _location2;
        Player player;
        CommandProcessor _command;
        Item sword;
        

        [SetUp]
        public void Setup()
        {
            _command = new CommandProcessor();    
            player = new Player("lily", "Tired");
            
            _location1 = new Location(new string[] { "swin", "burne" }, "Swinburne", "A place to study.");
            _location2 = new Location(new string[] { "home", "house" }, "Home", "A place to sleep.");
            sword = new Item(new string[] { "sword" }, "Sword", " sturdy weapon.");
            player.Location = _location1;
            
            player.Map.AddLocation(_location1);
            player.Map.AddLocation(_location2);

            player.Inventory.Put(sword);
        }

        [Test]
        public void CommandError()
        {
            Assert.AreEqual(_command.Execute(player, new string[] { "wrong", "sword" }), "I don't understand wrongsword");
        }

        [Test]
        public void PutSucess()
        {
            Assert.AreEqual(_command.Execute(player, new string[] { "put","sword"}), "Sucess put Sword in Swinburne");
        }

        [Test]
        public void PutLocationCheck()
        {
            _command.Execute(player, new string[] { "put", "sword" });
            Assert.AreEqual(_location1.Locate("sword").Name, "Sword");
        }

        [Test]
        public void PutFail()
        {
            Assert.AreEqual(_command.Execute(player, new string[] { "put", "pen" }), "Player does not posess pen to put into desired location");
        }
    }
}