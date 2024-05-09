namespace RetrieveFormTest;
using CustomProject;

public class Tests
{
    Item item;
    SendForm form;
    FormFactory f;
    SqlServer sqlServer;
    Location location;
    string output;

    [SetUp]
    public void Setup()
    {
        form = null;
        f = new FormFactory();
        sqlServer = new SqlServer();
        location = new Location(new string[] { "1" }, "first floor using id", "first floor", 1);
    }


}