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

    [Test]
    public void PutSuccess()
    {
        item = new Item(new string[] { "new item" }, "new item", "new item to add");
        form = f.MakeForm("retrieve");
        output = form.Execute(sqlServer, item, location);
        Assert.AreEqual(output, "More than 1 item found, please retry with more specific name and ids");
    }
}