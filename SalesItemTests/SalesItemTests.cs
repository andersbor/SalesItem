using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesItem.Tests
{
    [TestClass]
    public class SalesItemTests
    {
        private readonly SalesItem _item = new SalesItem();

        [TestMethod]
        public void NormalTest()
        {
            _item.Name = "ab";
            Assert.AreEqual("ab", _item.Name);
            _item.Price = 14.95;
            Assert.AreEqual(14.95, _item.Price);

            _item.Price = Math.PI;
            Assert.AreEqual(3.14159265, _item.Price, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameNullTest()
        {
            _item.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameShortTest()
        {
            _item.Name = "a";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PriceNegativeTest()
        {
            _item.Price = -0.01;
        }

        [TestMethod]
        public void ToStringTest()
        {
            SalesItem item = new SalesItem {Id = 1, Name = "pencil", Price = 4};
            Assert.AreEqual("1 pencil 4", item.ToString());
        }
    }
}