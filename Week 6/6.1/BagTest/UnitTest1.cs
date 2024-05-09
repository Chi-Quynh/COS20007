using Ass24;
using System.Numerics;

namespace BagTest
{
    [TestFixture]
    public class Tests
    {
        

        Bag b;
        Bag b1;
        Item spoon = new Item(new string[] { "spoon" }, "a spoon", "Can be used for eating but also as an inefficent weapon");
        Item plate = new Item(new string[] { "plate" }, "a plate", "Simple plate");
        Item diamond = new Item(new string[] { "diamond" }, "a diamond", "This is a diamond");
        Item gold = new Item(new string[] { "gold" }, "a gold", "This is a gold");


        [SetUp]
        public void Setup()
        {
            
            b = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            b1 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");
            b.Inventory.Put(plate); b.Inventory.Put(spoon); //Adding item to bag
            b1.Inventory.Put(diamond); b1.Inventory.Put(gold); //Adding item to bag1


        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.IsTrue(b.Inventory.HasItem("spoon")); 
            Assert.IsTrue(b.Inventory.HasItem("plate"));

            Assert.IsTrue(b.Locate(spoon.FirstId) == spoon); 
            Assert.IsTrue(b.Locate(plate.FirstId) == plate);

        }

        [Test]
        public void TestBagLocatesItems2()
        {
            Assert.IsTrue(b.Locate("bag") == b);
        }

        [Test]
        public void TestLocateNothing()
        {
            Assert.IsTrue(b.Locate("none") == null);
        }

        [Test]
        public void TestFullDescription() 
        {
            Assert.AreEqual(b.FullDescription, "In the a bag you can see:a spoon (spoon)");
        }

        [Test]
        public void BaginBag() {
            b.Inventory.Put(b1);
            Assert.IsTrue(b.Locate("bag1") == b1);
            Assert.IsTrue(b.Locate("plate") == plate);
            Assert.IsTrue(b.Locate("diamond") == null );
        }
    }
}