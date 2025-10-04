namespace App.Topics.ConstrainedClasses.T2_WarehouseManager
{
    public class Product
    {
        public int ID { get; }
        public string Name { get; }

        public Product(int id, string name)
        {
            ID = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }

    public class Electronics : Product
    {
        public int WarrantyMonths { get; }

        public Electronics(int id, string name, int warrantyMonths)
            : base(id, name)
        {
            WarrantyMonths = warrantyMonths;
        }
    }

    public class Food : Product
    {
        public DateTime ExpirationDate { get; }

        public Food(int id, string name, DateTime expirationDate)
            : base(id, name)
        {
            ExpirationDate = expirationDate;
        }
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