using Ass24;
using System.Numerics;

namespace PathTest
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
            _path = new Ass24.Path("North", _location1,_location2);
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
        public void PathMove()
        {
            
            string result = _move.Execute(player, new string[] { "move", "North" });
            Assert.AreEqual($"You have moved {_path.Direction} through a {_path.Name} to {player.Location.Name}", result );
        }

        [Test]
        public void PathInvalid()
        {
            string result = _move.Execute(player, new string[] { "move", "South" });
            Assert.AreEqual("Cannot execute because the path is null", result);
        }
    }
}