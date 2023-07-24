using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Order
    {
        private static List<Order> _orders = new List<Order>();
        public string Name { get; set; }
        public int Id { get; }

        public Order()
        {
        
        }

        public Order(string name)
        {
            Name = name;
            _orders.Add(this);
            Id = _orders.Count;
        }

        // Add methods below
    }
}
