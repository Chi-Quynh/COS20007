using Program;

namespace Test31
{
    public class CounterTests
    {
        Program.Counter _test;
        [SetUp]
        public void Setup()
        {
            _test = new Program.Counter("");
        }

        [Test]
        public void Test1()
        {
            int _result = _test.Ticks;
            Assert.That(_result,Is.EqualTo(0));
        }
        [Test]
        public void Test2()
        {
            _test.Increment();
            Assert.That(1, Is.EqualTo(_test.Ticks));
        }
        [Test]
        public void Test3()
        {
            _test.Increment();
            _test.Increment();
            _test.Increment();
            Assert.That(3, Is.EqualTo(_test.Ticks));
        }

        [Test]
        public void Test4()
        {
            _test.Increment();
            _test.Reset();
            Assert.That(0, Is.EqualTo(_test.Ticks));
        }
    }
}