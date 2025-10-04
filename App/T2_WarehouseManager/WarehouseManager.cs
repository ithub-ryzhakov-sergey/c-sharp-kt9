namespace App.T2_WarehouseManager;

public class Product
{
    public int ID { get; init; }
    public string Name { get; init;}
}

public class Electronics : Product {
    public Electronics(int id, string name, int warrantyMonths)
    {
        this.ID = id;
        this.Name = name;
        this.WarrantyMonths = warrantyMonths;
    }
    public int WarrantyMonths { get; }
}
public class Food : Product
{
    public Food(int id, string name, DateTime expirationDate)
    {
        this.ID = id;
        this.Name = name;
        this.ExpirationDate = expirationDate;
    }
    public DateTime ExpirationDate { get; }
}

public class WarehouseManager<T> where T : Product
{
    private IEnumerable<T> Items;
    public WarehouseManager(IEnumerable<T> items)
    {
        if (items == null) { throw new ArgumentNullException(); }
        this.Items = items;
    }
    public void PrintBasicInfo()
    {
        foreach (var item in Items)
        {
            System.Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
        }
    }
}
