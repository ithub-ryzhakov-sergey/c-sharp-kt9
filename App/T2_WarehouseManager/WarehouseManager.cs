namespace App.Topics.ConstrainedClasses.T2_WarehouseManager;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Electronics : Product
{
    public int WarrantyMonths { get; set; }
    public Electronics(int id, string name, int warrantyMonths)
    {
        Id = id;
        Name = name;
        WarrantyMonths = warrantyMonths;
    }
}

public class Food : Product
{
    public DateTime ExpirationDate { get; set; }
    public Food(int id, string name, DateTime expirationDate)
    {
        Id = id;
        Name = name;
        ExpirationDate = expirationDate;
    }
}

public class WarehouseManager<T>
    where T : Product
{
    private IEnumerable<T> items;
    public WarehouseManager(IEnumerable<T>? items)
    {
        if (items == null)
            throw new ArgumentNullException("items");

        this.items = items;
    }

    public void PrintBasicInfo()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
        }
    }
}

public class Test
{
    public void T()
    {
        var electronics = new Product[]
        {
            new Electronics(1, "a", 2),
            new Food(1, "b", DateTime.Now)
        };
        var manager = new WarehouseManager<Product>(electronics);
        manager.PrintBasicInfo();
    }
}