using Ass24;
using System.Numerics;

namespace LocationTest
{
    public class Tests
    {
        Location _location;
        Player player;
        Item spoon;
        Item plate;


        [SetUp]


        public void Setup()
        {
            player = new Player("lily", "Tired");

            spoon = new Item(new string[] { "spoon" }, "a spoon", "Can be used for eating but also as an inefficent weapon");
            plate = new Item(new string[] { "plate" }, "a plate", "Simple plate");
            _location = new Location(new string[] {"blue","lock" }, "Blue Lock", "A sport stadium");
            _location.Inventory.Put(spoon);
            _location.Inventory.Put(plate);
        }

        [Test]
        public void SelfIdentify()
        {
            Assert.AreEqual(_location.Locate(_location.FirstId),_location);
        }

        [Test]
        public void ItemIdentify()
        {
            Assert.AreEqual(_location.Locate(spoon.FirstId), spoon);
            Assert.AreEqual(_location.Locate(plate.FirstId), plate);
        }

        [Test]
        public void PlayerIdentify()
        {
            player.Location = _location;
            Assert.AreEqual(player.Locate(spoon.FirstId), spoon);
        }
    }
}