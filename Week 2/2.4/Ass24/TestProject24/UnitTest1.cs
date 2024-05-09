using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program;


namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        Program.Program _program;



        [SetUp]
        public void Setup()
        {
            _program = new Program.Program();

        }

        [Test]
        public void TestMethod1()
        {
            string[] identifiers = { "fred", "bob" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            bool result = identifiableObject.AreYou(identifiers[0]);
            Assert.IsTrue(result);
            bool result2 = identifiableObject.AreYou(identifiers[1]);
            Assert.IsTrue(result2);
        }

        [Test]
        public void TestMethod2()
        {
            string[] identifiers = { "fred", "bob" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            bool result = identifiableObject.AreYou("not fred");
            Assert.IsFalse(result);
        }

        [Test]
        public void TestMethod3()
        {
            string[] identifiers = { "fred", "bob" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            bool result = identifiableObject.AreYou("FRED");
            Assert.IsTrue(result);
        }

        [Test]
        public void TestMethod4()
        {
            string[] identifiers = { "fred", "bob" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            string result = identifiableObject.FirstId;
            Assert.AreEqual(identifiers[0], result);
        }

        [Test]
        public void TestMethod5()
        {
            string[] identifiers = { "" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            string result = identifiableObject.FirstId;
            Assert.IsEmpty(result);
        }

        [Test]
        public void TestMethod6()
        {
            string[] identifiers = { "fred", "bob" };
            IdentifiableObject identifiableObject = new IdentifiableObject(identifiers);
            identifiableObject.AddIdentifier("bob");
            foreach (string ident in identifiers)
            {
                bool result = identifiableObject.AreYou(ident);
                Assert.IsTrue(result);
            }


        }
    }
}