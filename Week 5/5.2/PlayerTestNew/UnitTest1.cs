using Ass24;
using System.Numerics;
//was not running, solution: run from solution

namespace PlayerTest
{
    public class TestPlayer
    {
        Ass24.Player _player;
        [SetUp]
        public void SetUp() { 
        _player = new Player("id1", "id2");
        }
        [Test]
        public void PlayerIdentifierTest() {  Assert.IsTrue(_player.AreYou("me")); }
        [Test]
        public void PlayerLocaterTest() { Assert.IsTrue(_player.Locate("me") == _player); }
        [Test]
        public void PlayerItemLocaterTest()
        {
            Item TestItem = new Item(new string[] { "sheild", "hard" }, "hard sheild", "a hardsheild");
            _player.Inventory.Put(TestItem); 
            Assert.IsTrue(_player.Locate("sheild") == TestItem);
        }

        [Test]
        public void PlayerItemNotlocated() { Assert.IsFalse(_player.Locate("nope") == _player); }

        [Test]
        public void PlayerFullDescription() { Assert.AreEqual(_player.FullDescription, "You are id1,id2. You are carrying:id1 (me)") ; }

    }
}
