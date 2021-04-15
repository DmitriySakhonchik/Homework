using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using ProductManagement;
using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommands;

namespace ProductManagementTests.ProductManagerCommands
{
    [TestClass()]
    public class CountTypesCommandTests
    {
        private const string type1 = "Type one";
        private const string type2 = "Type two";
        private const string type3 = "Type three";

        private const string name = "Name";

        private const string quantity1 = "3";
        private const string quantity2 = "6";
        private const string quantity3 = "9";

        private const string price1 = "4.2";
        private const string price2 = "6.3";
        private const string price3 = "4.5";

        [TestMethod()]
        [ExpectedException(typeof(CommandException))]
        public void CountTypesCommand_ConstructorTest_ThrowsCommandException()
        {
            CountTypesCommand command = new CountTypesCommand("count all");
        }

        [TestMethod()]
        public void CountTypesCommand_Perform()
        {
            CountTypesCommand command = new CountTypesCommand("count types");
            List<Product> products = new List<Product>();
            const string type1 = "Type one";
            const string type2 = "Type two";
            const string type3 = "Type three";

            const string name = "Name";

            const string quantity = "3";
            const string price = "4.2";

            string[] productInfo1 = { type1, name, quantity, price };
            string[] productInfo2 = { type2, name, quantity, price };
            string[] productInfo3 = { type2, name, quantity, price };
            products.Add(new Product(productInfo1));
            products.Add(new Product(productInfo2));
            products.Add(new Product(productInfo3));

            command.Perform(products);

            double expected = 2;
            Assert.AreEqual(expected, (int)command.Result, Double.Epsilon);
        }
    }
}