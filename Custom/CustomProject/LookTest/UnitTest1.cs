using CustomProject;
using System.Numerics;

namespace LookTest
{
    public class Tests
    {
        CommandProcessor c;
        Location _location;
        LocationList _locations;
        Item spoon;
        Item plate;


        [SetUp]


        public void Setup()
        {


            _locations = new LocationList();
            c = new CommandProcessor();

            spoon = new Item(new string[] { "spoon" }, "a spoon", "Can be used for eating but also as an inefficent weapon");
            plate = new Item(new string[] { "plate" }, "a plate", "Simple plate");
            _location = new Location(new string[] { "bluelock", "lock" }, "Blue Lock", "a sport stadium");
 
            _locations.AddLocation(_location);
        }

        [Test]
        public void LookAtLocationSucess()
        {
            string[] inputArray = "look at bluelock".Split(' ');
            string[] input = { "look" };
            Assert.AreEqual("There are 1 locations in the school:\nBlue Lock, a sport stadium. There is no item at the location", c.Execute(_locations, input));
        }

        [Test]
        public void LookAgtLocationFail()
        {
            string[] inputArray = "look at sylvain".Split(' ');
            Assert.AreEqual(c.Execute(_locations, inputArray), "Unable to find location");
        }


        [Test]
        public void LookForItemSucess()
        {
            _location.Inventory.Put(spoon);
            _location.Inventory.Put(plate);
            

        }
    }
}