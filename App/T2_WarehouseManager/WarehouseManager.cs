using System;
using System.Collections.Generic;

namespace App.Topics.ConstrainedClasses.T2_WarehouseManager
{
    // Базовый класс Product
    public abstract class Product
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }

        protected Product(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }

    // Производный класс Electronics
    public class Electronics : Product
    {
        public int WarrantyMonths { get; private set; }

        public Electronics(int id, string name, int warrantyMonths)
            : base(id, name)
        {
            WarrantyMonths = warrantyMonths;
        }
    }

    // Производный класс Food
    public class Food : Product
    {
        public DateTime ExpirationDate { get; private set; }

        public Food(int id, string name, DateTime expirationDate)
            : base(id, name)
        {
            ExpirationDate = expirationDate;
        }
    }

    // Универсальный класс менеджера
    public class WarehouseManager<T> where T : Product
    {
        private readonly IEnumerable<T> _items;

        public WarehouseManager(IEnumerable<T> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void PrintBasicInfo()
        {
            foreach (var item in _items)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
            }
        }
    }
}