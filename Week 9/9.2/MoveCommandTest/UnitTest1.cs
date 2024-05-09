using System.Numerics;
using Ass24;

namespace MoveCommandTest
{
    public class Tests
    {
        Location _location1;
        Location _location2;
        Player player;
        Ass24.Path _path;
        MoveCommand _move;
        [SetUp]
        public void Setup()
        {
            player = new Player("lily", "Tired");
            _location1 = new Location(new string[] { "swin", "burne" }, "Swinburne", "A place to study.");
            _location2 = new Location(new string[] { "home", "house" }, "Home", "A place to sleep.");
            _path = new Ass24.Path("North", _location1, _location2);
            _location1.AddPath(_path);
            _move = new MoveCommand();
            player.Location = _location1;
        }

        [Test]
        public void PathName()
        {
            Assert.AreEqual(player.Location.FullDescription, _location1.FullDescription);
        }

        [Test]
        public void PathDirection()
        {
            Assert.AreEqual(_path.Direction, "North");
        }

        [Test]
        public void PathDestination()
        {
            Assert.AreEqual(_path.Destination, _location2);
        }

    }
}