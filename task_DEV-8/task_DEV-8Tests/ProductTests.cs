using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using ProductManagement;

namespace ProductManagementTests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void Product_ConstructorTest_WhenInvalidTypeThrowsFormatException()
        {
            const string type = "111";
            const string name = "Milk";
            const string quantity = "3";
            const string price = "4";
            string[] productInfo = new string[] { type, name, quantity, price };
            Product product = new Product(productInfo);
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void Product_ConstructorTest_WhenInvalidNameThrowsFormatException()
        {
            const string type = "Milk";
            const string name = "222";
            const string quantity = "3";
            const string price = "4";
            string[] productInfo = new string[] { type, name, quantity, price };
            Product product = new Product(productInfo);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Product_ConstructorTest_WhenInvalidQuantityThrowsArgumentOutOfRangeException()
        {
            const string type = "Milk";
            const string name = "Milk";
            const string quantity = "-3";
            const string price = "4";
            string[] productInfo = new string[] { type, name, quantity, price };
            Product product = new Product(productInfo);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Product_ConstructorTest_WhenInvalidPriceThrowsArgumentOutOfRangeException()
        {
            const string type = "Milk";
            const string name = "Milk";
            const string quantity = "3";
            const string price = "0";
            string[] productInfo = new string[] { type, name, quantity, price };
            Product product = new Product(productInfo);
        }
    }
}
