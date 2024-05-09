using Ass24;

namespace InventoryUnitTest
{
    public class Tests
    {
        Ass24.Inventory _inventory;
        Ass24.Item _item;
        [SetUp]
        public void Setup()
        {
            _item = new Item(new string[] { "id1", "id2" }, "Lily", "a tired programmer");
            _inventory = new Ass24.Inventory();
            _inventory.Put(_item);
        }

        [Test]
        public void FindItem()
        {
            bool result = _inventory.HasItem("id1");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoItemFind()
        {
            bool result = _inventory.HasItem("nope");
            Assert.IsFalse(result);
        }
        [Test]
        public void FetchItem()
        {
            Item result = _inventory.Fetch("id1");
            Assert.AreEqual(_item, result);
        }
        [Test]
        public void TakeItem() 
        {
            Item result = _inventory.Take("id1");
            Assert.AreEqual(_item, result);
        }
        [Test]
        public void ItemList()
        {
            string result = _inventory.ItemList;
            Assert.AreEqual(_item.ShortDescription, result);
        }
    }
}