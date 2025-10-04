namespace App.Topics.ConstrainedClasses.T2_WarehouseManager
{
    public class Product(int id, string name)
    {
        public int ID { get; } = id;
        public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
    }

    public class Electronics(int id, string name, int warrantyMonths) : Product(id, name)
    {
        public int WarrantyMonths { get; } = warrantyMonths;
    }

    public class Food(int id, string name, DateTime expirationDate) : Product(id, name)
    {
        public DateTime ExpirationDate { get; } = expirationDate;
    }

    public class WarehouseManager<T> where T : Product
    {
        public IEnumerable<T> Iitems;

        public WarehouseManager(IEnumerable<T> items)
        {
            _ = items ?? throw new ArgumentNullException(nameof(items));
           Iitems = items;
        }

        public void PrintBasicInfo()
        {
            foreach (var item in Iitems)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
            }
        }
    }
}