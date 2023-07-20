using System.Collections.Generic;


namespace VendorApp.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string Name { get; set; }

        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

    }
}