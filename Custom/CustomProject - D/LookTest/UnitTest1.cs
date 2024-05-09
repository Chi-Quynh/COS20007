using CustomProject;
using System.Numerics;

namespace LookTest
{
    public class Tests
    {
        Command c;
        CommandFactory factory;
        Location _location;
        ILocationList _locations;
        Item spoon;
        Item plate;


        [SetUp]


        public void Setup()
        {


            _locations = new LocationList();
            factory = new CommandFactory();
            c = null;

            spoon = new Item(new string[] { "spoon" }, "a spoon", "Can be used for eating but also as an inefficent weapon");
            plate = new Item(new string[] { "plate" }, "a plate", "Simple plate");
            _location = new Location(new string[] { "bluelock", "lock" }, "Blue Lock", "a sport stadium");
 
            _locations.AddLocation(_location);
        }

        [Test]
        public void LookAtLocationSucess()
        {
            string[] inputArray = "look at bluelock".Split(' ');
            
            c = factory.makeCommand(inputArray);
            Assert.AreEqual("Blue Lock, a sport stadium. There is no item at the location", c.Execute(_locations, inputArray));
        }

        [Test]
        public void LookAgtLocationFail()
        {
            string[] inputArray = "look at sylvain".Split(' ');

            c = factory.makeCommand(inputArray);
            Assert.AreEqual("Unable to find location", c.Execute(_locations, inputArray));
        }


        [Test]
        public void LookForItemSucess()
        {
            _location.Inventory.Put(spoon);
            _location.Inventory.Put(plate);
            

        }

        [Test]
        public void TakeItemSucess()
        {
            _location.Inventory.Put(spoon);
            _location.Inventory.Put(plate);
            string[] inputArray = "take spoon".Split(' ');
            c = factory.makeCommand(inputArray);
            Assert.AreEqual(c.Execute(_locations, inputArray), "Taken a spoon at Blue Lock");

        }
    }
}