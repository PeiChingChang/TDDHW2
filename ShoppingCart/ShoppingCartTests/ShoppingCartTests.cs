using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void 第一集買了一本_共買一本_價格為100()
        {
            // Arrange
            var target = new ShoppingCart();
            var books = new List<book>()
            {
                new book() { Id = 1,Name="HarryPorter1",Price=100},
            };

            // Act
            var actual = target.CalculateAmount(books);

            // Assert
            var expectedResult = 100;
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二集買了一本_共買兩本_價格為190()
        {
            // Arrange
            var target = new ShoppingCart();
            var books = new List<book>()
            {
                new book() { Id = 1,Name="HarryPorter1",Price=100},
                new book() { Id = 2,Name="HarryPorter2",Price=100},
            };

            // Act
            var actual = target.CalculateAmount(books);

            // Assert
            var expectedResult = 190;
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod()]
        public void 一二三集各買一本_共買三本_價格為270()
        {
            // Arrange
            var target = new ShoppingCart();
            var books = new List<book>()
            {
                new book() { Id = 1,Name="HarryPorter1",Price=100},
                new book() { Id = 2,Name="HarryPorter2",Price=100},
                new book() { Id = 3,Name="HarryPorter3",Price=100},
            };

            // Act
            var actual = target.CalculateAmount(books);

            // Assert
            var expectedResult = 270;
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod()]
        public void 一二三四集各買一本_共買四本_價格為320()
        {
            // Arrange
            var target = new ShoppingCart();
            var books = new List<book>()
            {
                new book() { Id = 1,Name="HarryPorter1",Price=100},
                new book() { Id = 2,Name="HarryPorter2",Price=100},
                new book() { Id = 3,Name="HarryPorter3",Price=100},
                new book() { Id = 4,Name="HarryPorter4",Price=100},
            };

            // Act
            var actual = target.CalculateAmount(books);

            // Assert
            var expectedResult = 320;
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod()]
        public void 一二三四五集各買一本_共買五本_價格為375()
        {
            // Arrange
            var target = new ShoppingCart();
            var books = new List<book>()
            {
                new book() { Id = 1,Name="HarryPorter1",Price=100},
                new book() { Id = 2,Name="HarryPorter2",Price=100},
                new book() { Id = 3,Name="HarryPorter3",Price=100},
                new book() { Id = 4,Name="HarryPorter4",Price=100},
                new book() { Id = 5,Name="HarryPorter5",Price=100},
            };

            // Act
            var actual = target.CalculateAmount(books);

            // Assert
            var expectedResult = 375;
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
