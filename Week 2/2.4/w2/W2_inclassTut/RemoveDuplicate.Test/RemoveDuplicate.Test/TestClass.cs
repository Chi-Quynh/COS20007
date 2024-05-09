using NUnit.Framework;
using RemoveDuplicate;
namespace RemoveDuplicate.Test
{
    [TestFixture]
    public class TestClass
    {
        RemoveDuplicate.Program _testOb;
        [SetUp]
        public void SetUp() {
            _testOb = new RemoveDuplicate.Program();
        }

        [Test]
        public void TestNull()
        {
            List<int> testList = new List<int>();
            List<int> expected = new List<int>();
            var result = _testOb.DuplicateRemove(testList);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestCorrectness()
        {
            List<int> testList = new List<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(2);
            // test list should contain [1,2,3,2]
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            // expected should contains [1,2,3]
            var result = _testOb.DuplicateRemove(testList);
            CollectionAssert.AreEqual(expected, result);
            Assert.NotNull(result);
        }
    }
}