using System.Collections.Generic;
using VendorApp.Models;

namespace VendorApp.Tests
{
    [TestClass]
    public class CategoryTests : IDisposable
    {

        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            // Arrange
            string name1 = "Vendor1";
            string name2 = "Vendor2";
            Vendor vendor1 = new(name1);
            Vendor vendor2 = new(name2);
            List<Vendor> vendorList = new List<Vendor> { vendor1, vendor2 };
            // Act
            List<Vendor> result = Vendor.GetAll();
            // Assert
            CollectionAssert.AreEqual(vendorList, result);
        }

        [TestMethod]
        public void Find_FindVendorById_Vendor()
        {
            // Arrange
            string name1 = "Vendor1";
            string name2 = "Vendor2";
            Vendor vendor1 = new(name1);
            Vendor vendor2 = new(name2);
            // Act
            Vendor result = Vendor.Find(2);
            // Assert
            Assert.AreEqual(result, vendor2);
        }

        [TestMethod]
        public void AddOrder_AssociateOrderWithVendor_OrderList()
        {
            // Arrange
            // Create order and add to list
            string order1 = "BBQ Sauce";
            Order newOrder = new(order1);
            List<Order> newOrderList = new List<Order> { newOrder };
            // Create vendor object
            string vendor1 = "Jamomma's Jerk";
            Vendor newVendor = new(vendor1);
            newVendor.AddOrder(newOrder);
            // Act
            List<Order> result = newVendor.VendorOrderList;
            // Assert
            CollectionAssert.AreEqual(result, newOrderList);
        }
    }
}