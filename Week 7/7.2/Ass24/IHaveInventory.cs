namespace Ass24
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);


        string Name { get; }
    }
}
