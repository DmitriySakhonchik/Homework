﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using ProductManagement;
using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommands;

namespace ProductManagementTests.ProductManagerCommands
{
    [TestClass()]
    public class AveragePriceTypeCommandTests
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
        public void AveragePriceTypeCommand_ConstructorTest_ThrowsCommandException()
        {
            AveragePriceTypeCommand command = new AveragePriceTypeCommand("count all");
        }

        [TestMethod()]
        public void AveragePriceTypeCommand_Perform()
        {
            AveragePriceTypeCommand command = new AveragePriceTypeCommand("average price " + type1);
            List<Product> products = new List<Product>();
            string[] productInfo1 = { type1, name, quantity1, price1 };
            string[] productInfo2 = { type2, name, quantity2, price2 };
            string[] productInfo3 = { type1, name, quantity3, price3 };
            products.Add(new Product(productInfo1));
            products.Add(new Product(productInfo2));
            products.Add(new Product(productInfo3));

            command.Perform(products);

            double expected = 4.35;
            Assert.AreEqual(expected, (double)command.Result, Double.Epsilon);
        }
    }
}