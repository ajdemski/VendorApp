using System.Collections.Generic;
using VendorApp.Models;

namespace VendorApp.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CreateOrder_ShouldSetProperties()
        {
            // Arrange
            string orderName = "BBQ Sauce";
            // Act
            Order order = new Order(orderName);
            // Assert
            Assert.AreEqual(orderName, order.Name);
        }
    }
}