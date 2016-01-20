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
    }
}
