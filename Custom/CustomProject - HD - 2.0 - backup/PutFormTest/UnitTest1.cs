using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using System.Xml.Linq;
using CustomProject;
using MySql.Data.MySqlClient;

namespace PutFormTest
{
    public class PutTest
    {
        
        Item item;
        SendForm form;
        FormFactory f;
        SqlServer sqlServer;
        Location location;
        string output;
        string _decoyname;

        [SetUp]
        public void Setup()
        {
            form = null;
            f = new FormFactory();
            sqlServer = new SqlServer();
            location = new Location(new string[] { "1" }, "first floor using id", "first floor", 1);
            _decoyname = "new item 2";
        }

        [Test]
        public void PutSuccess()
        {
            item = new Item(new string[] { "new item" }, _decoyname, "new item to add");
            form = f.MakeForm("post");
            output = form.Execute(sqlServer, item, location);
            Assert.AreEqual(output, $"Item '{_decoyname}' posted successfully at 'first floor using id'. Description: new item to add.\nIds: 'new item'.");
        }
        [Test]
        public void PutSuccessEmptyString()
        {
            item = new Item(new string[] { "" }, "new item", "new item to add");
            form = f.MakeForm("post");
   
            output = form.Execute(sqlServer, item, location);
            Assert.AreEqual(output, "Item 'new item' posted successfully at 'first floor using id'. Description: new item to add.\nIds: ''.");
        }

        [Test]
        public void PutFailBecauseofItemNull()
        {
            //item = new Item(new string[] { "new's item" }, "new item", "new item to add");
            form = f.MakeForm("post");
            
            output = form.Execute(sqlServer, item, location);
            Assert.AreEqual(output, "Error: Null item to post.");
        }

        [Test]
        public void PutFailBecauseofDuplicate()
        {
            item = new Item(new string[] { "new item" }, "new item", "new item to add");
            form = f.MakeForm("post");
            output = form.Execute(sqlServer, item, location);
            Assert.AreEqual(output, $"Duplicate item found. Please re-enter and try again");
        }

        [Test]
        public void GetList()
        {

            ILocationList list = sqlServer.GetList();



            Assert.AreEqual(list.GetList[0].Name, "first floor");
            Assert.AreEqual(string.Join(',',list.GetList[0].IDs), "first, floor");
            Assert.AreEqual(list.GetList[0].Description, "has library");
            Assert.AreEqual(list.GetList[0].GetKey, 1);
        }


    }
}