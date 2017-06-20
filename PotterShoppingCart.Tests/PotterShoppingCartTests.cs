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
        [TestMethod()]
        public void CalculateTotalPriceTest_第一集1本_預計回傳100()
        {
            //Arrange
            const string episode1Isbn = "9573317249";
            var books = new Dictionary<string, int>()
            {
                { episode1Isbn, 1}
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
            const string episode1Isbn = "9573317249";
            const string episode2Isbn = "9573317583";
            var books = new Dictionary<string, int>()
            {
                { episode1Isbn, 1},
                { episode2Isbn, 1}
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
            const string episode1Isbn = "9573317249";
            const string episode2Isbn = "9573317583";
            const string episode3Isbn = "9573318008";
            var books = new Dictionary<string, int>()
            {
                { episode1Isbn, 1},
                { episode2Isbn, 1},
                { episode3Isbn, 1}
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
            const string episode1Isbn = "9573317249";
            const string episode2Isbn = "9573317583";
            const string episode3Isbn = "9573318008";
            const string episode4Isbn = "9573318318";
            var books = new Dictionary<string, int>()
            {
                { episode1Isbn, 1},
                { episode2Isbn, 1},
                { episode3Isbn, 1},
                { episode4Isbn, 1},
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
            const string episode1Isbn = "9573317249";
            const string episode2Isbn = "9573317583";
            const string episode3Isbn = "9573318008";
            const string episode4Isbn = "9573318318";
            const string episode5Isbn = "9573319861";
            var books = new Dictionary<string, int>()
            {
                { episode1Isbn, 1},
                { episode2Isbn, 1},
                { episode3Isbn, 1},
                { episode4Isbn, 1},
                { episode5Isbn, 1},
            };
            var expected = 375;

            //Act
            var actual = PotterShoppingCart.CalculateTotalPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}