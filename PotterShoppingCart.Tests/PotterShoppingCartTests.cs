using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        private const string EPISODE1_ISBN = "9573317249";
        private const string EPISODE2_ISBN = "9573317583";
        private const string EPISODE3_ISBN = "9573318008";
        private const string EPISODE4_ISBN = "9573318318";
        private const string EPISODE5_ISBN = "9573319861";

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_預計回傳100()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1}
            };
            var expected = 100;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_預計回傳190()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1},
                { EPISODE2_ISBN, 1}
            };
            var expected = 190;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_預計回傳270()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1},
                { EPISODE2_ISBN, 1},
                { EPISODE3_ISBN, 1}
            };
            var expected = 270;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_第四集1本_預計回傳320()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1},
                { EPISODE2_ISBN, 1},
                { EPISODE3_ISBN, 1},
                { EPISODE4_ISBN, 1},
            };
            var expected = 320;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集1本_第四集1本_第五集1本_預計回傳375()
        {
            //Arrange
            
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1},
                { EPISODE2_ISBN, 1},
                { EPISODE3_ISBN, 1},
                { EPISODE4_ISBN, 1},
                { EPISODE5_ISBN, 1},
            };
            var expected = 375;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_第二集1本_第三集2本_預計回傳370()
        {
            //Arrange
            var books = new Dictionary<string, int>()
            {
                { EPISODE1_ISBN, 1},
                { EPISODE2_ISBN, 1},
                { EPISODE3_ISBN, 2},
            };
            var expected = 370;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}