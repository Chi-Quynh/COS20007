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
        

        SqlServer server;


        [SetUp]


        public void Setup()
        {
            server = new SqlServer();
            _locations = server.GetList();
            _location = _locations.GetList[0];


        }

      

        [Test]
        public void LookforappleNameSucess()
        {


            string output ="";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "apple");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual( output,"Item: apple.Desc: an apple. Location: first floor. Ids: apple, food\n" );
            

        }


        [Test]
        public void LookforappleIDSucess()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "food");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual(output, "Item: apple.Desc: an apple. Location: first floor. Ids: apple, food\n");


        }

        [Test]
        public void LookfordecoyIDFail()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location, "decoy name");

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

            queryresult = c.Execute(_location,  "apple's food");

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

            queryresult = c.Execute(_location, "first floor");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual("Location: first floor. Desc: has library. Ids: first, floor\n", output);


        }

        [Test]
        public void Lookfor1stFloorIDSuccess()
        {


            string output = "";
            List<string> queryresult;



            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(_location,  "first");

            //Set label text here
            foreach (string i in queryresult)
            {
                output += i + "\n";
            }


            Assert.AreEqual("Location: first floor. Desc: has library. Ids: first, floor\n", output);


        }
    }
}