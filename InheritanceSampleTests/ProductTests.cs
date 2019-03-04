using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        [DataRow("C# is cool")]
        [DataRow("This is a title with thirty ch")]
        public void Constructor_ValidTitle_SetsTitle(string title)
        {
            Product p = new Product(title);

            string result = p.Title;

            Assert.AreEqual(title, result);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("          ")]
        [DataRow("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")]
        public void Constructor_InvalidTitle_ThrowsArgumentException(string title)
        {
            Assert.ThrowsException<ArgumentException>(() => new Product(title));
        }
    }
}