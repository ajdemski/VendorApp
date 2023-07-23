using System.Collections.Generic;


namespace VendorApp.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor>() { };
        public static int _nextId = 1;
        public string Name { get; set; }

        public int Id { get; }
        public List<Order> VendorOrderList { get; set; }

        public Vendor()
        {
            VendorOrderList = new List<Order> { };
        }
        public Vendor(string name) : this()
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor Find(int id)
        {
            return _instances.Find(vendor => vendor.Id == id);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public void AddOrder(Order order)
        {
            VendorOrderList.Add(order);
        }
    }
}