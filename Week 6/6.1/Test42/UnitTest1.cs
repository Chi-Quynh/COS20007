
using Ass24;


namespace Test42
{
    public class Tests
    {
        Ass24.Item _identifiable;
        [SetUp]
        public void Setup()
        {
            _identifiable = new Item(new string[] { "id1", "id2" }, "Lily", "a tired programmer");
        }

        //item unit tests

        [Test]
        public void Test1()
        {
            _identifiable.AreYou("id1");
            Assert.IsTrue(_identifiable.AreYou("id1"));
        }

        [Test]
        public void Test2()
        {
            string result = _identifiable.ShortDescription;
            Assert.AreEqual("Lily (id1)", result);
        }

        [Test]
        public void Test3()
        {
            string result = _identifiable.FullDescription;
            Assert.AreEqual("a tired programmer", result);
        }
    }
}