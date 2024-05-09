using CustomProject;
using System.Numerics;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Xml.Linq;
using MySqlX.XDevAPI.Common;
using static System.Net.Mime.MediaTypeNames;

namespace LookTest
{
    public class Tests
    {
        Command c;
        CommandFactory factory;
        CustomProject.Location _location;
        ILocationList _locations;
        Item spoon;
        Item plate;


        [SetUp]


        public void Setup()
        {
            _location = new CustomProject.Location(new string[] { "bluelock", "lock", "Blue Lock" }, "Blue Lock", "a sport stadium", 1);

            /*_locations = new LocationList();
            factory = new CommandFactory();
            c = null;

            spoon = new Item(new string[] { "spoon" }, "a spoon", "Can be used for eating but also as an inefficent weapon");
            plate = new Item(new string[] { "plate" }, "a plate", "Simple plate");
            
 
            _locations.AddLocation(_location);
            _location.Inventory.Put(spoon);*/
        }

        /*
        [Test]
        public void HasItem()
        {
            Post post = new Post();
            post.Execute(new string[] {"none"},"apple", "etc", _location);
            Assert.AreEqual(_locations.HasItem("apple"),_location);
        }

        [Test]
        public void LookAgtLocationFail()
        {
            
            Assert.AreEqual(_locations.Locate("Blue Lock"), _location);
        }


        [Test]
        public void LookForItemSucess()
        {
            Post post = new Post();
            post.Execute(new string[] { "none" }, "apple", "etc", _location);
            Assert.AreEqual(_location.Inventory.Fetch("none").Name, "apple");


        }

        [Test]
        public void putItem()
        {
            
                SendForm form = null;
                FormFactory f = new FormFactory();
                string output;


                 form = f.MakeForm("post");
                 output = form.Execute(new string[] {"apple"}, "apple", "an apple", _location);

                Assert.AreEqual(output, "Item posted successfully");


        }
        */

        [Test]
        public void LookforappleNameSucess()
        {


            string output ="";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "apple","id");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual(output, "Item: apple, an apple. Found at Blue Lock\n");
            

        }


        [Test]
        public void LookforappleIDSucess()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "name", "apple");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual(output, "Item: apple, an apple. Found at Blue Lock\n");


        }

        [Test]
        public void LookfordecoyIDFail()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "decoy name", "decoy id");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual(output, "Unable to find item\n");


        }

        [Test]
        public void LookfordecoyIDFail2()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "decoy name", "apple's food");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual(output, "Unable to find item\n");


        }


        [Test]
        public void Lookfor1stFloorNameSuccess()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "first floor", "decoy id");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual("Location: first floor", output);


        }

        [Test]
        public void Lookfor1stFloorIDSuccess()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "decoy name", "first");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual("Location: first floor", output);


        }
    }
}