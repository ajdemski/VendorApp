using System.Collections.Generic;

namespace VendorApp.Models
{
    public class Order
    {
        // Add fields below
        private static List<Order> _orders = new List<Order> { };
        public string Name { get; set; }
        // Add vendor constructor below
        public Order(string name)
        {
            Name = name;
            _orders.Add(this);
        }
        // Add methods below
    }
}