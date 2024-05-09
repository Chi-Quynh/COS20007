using Program;

namespace ClockTest31
{
    public class ClockTests
    {
        Program.Clock _test;
        [SetUp]
        public void Setup()
        {
            _test = new Program.Clock();
        }

        [Test]
        public void Test1()
        {
           
            Assert.That(_test.Show(), Is.EqualTo("00:00:00"));
        }

        [Test] 
        public void Test2()
        {
            _test.Tick();
            _test.Tick();
            Assert.That(_test.Show(), Is.EqualTo("00:00:02"));
        }

        [Test]
        public void Test3()
        {
            for (int i = 0; i <60;i++) { _test.Tick(); }
            Assert.That(_test.Show(), Is.EqualTo("00:01:00"));
        }

        [Test]
        public void Test4()
        {
            _test.Tick();
            _test.Tick();
            _test.ClockReset();
            Assert.That(_test.Show(), Is.EqualTo("00:00:00"));
        }
    }
}