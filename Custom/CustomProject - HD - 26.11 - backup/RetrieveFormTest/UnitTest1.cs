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
    public void RemoveSuccess()
    {
        item = new Item(new string[] { "new item" }, "new item", "new item to add");
        form = f.MakeForm("retrieve");
        output = form.Execute(sqlServer, item, location);
        Assert.AreEqual(output, "Item retrieved successfully");
    }

    [Test]
    public void RemoveFailed()
    {
        item = new Item(new string[] { "new item" }, "new item not found", "new item to add");
        form = f.MakeForm("retrieve");
        output = form.Execute(sqlServer, item, location);
        Assert.AreEqual(output, "Failed to retrieve item. Please check your name AND description.");
    }
}