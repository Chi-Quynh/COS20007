using Ass24;

namespace PlayerTest
{
    public class TestPlayer
    {
        [SetUp]
        public void SetUp() { }
        [Test]
        public void PlayerIdentifierTest() { Player TestPlayer = new Player("Fred", "Bob"); Assert.IsTrue(TestPlayer.AreYou("me")); }
        [Test]
        public void PlayerLocaterTest() { Player TestPlayer = new Player("Fred", "Bob"); Assert.IsTrue(TestPlayer.Locate("me") == TestPlayer); }
        [Test]
        public void PlayerItemLocaterTest()
        {
            Player TestPlayer = new Player("Fred", "Bob"); Item TestItem = new Item(new string[] { "sheild", "hard" }, "hard sheild", "a hardsheild");
            TestPlayer.Inventory.Put(TestItem); Assert.IsTrue(TestPlayer.Locate("sheild") == TestItem); Assert.IsTrue(TestPlayer.Locate("sheild") == TestItem);
        }
    }
}
