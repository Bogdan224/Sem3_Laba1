using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Alaba1.Tests
{
    [TestClass]
    public class Laptop_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, 22, 1.2)]
        public void Laptop_ShouldCreating(string brand, string model, int year, double price, double screenSize, double weight)
        {
            try
            {
                Assert.IsNotNull(new Laptop(brand, model, year, price, screenSize, weight));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, -22, 1.2)]
        [DataRow("Undefined", "Undefined", 2000, 1500, 22, -1.2)]
        [DataRow("Undefined", "Undefined", 2000, 1500, -22, -1.2)]
        public void Laptop_NotShouldCreating(string brand, string model, int year, double price, double screenSize, double weight)
        {
            Laptop laptop = null;
            try
            {
                laptop = new Laptop(brand, model, year, price, screenSize, weight);
            }
            catch
            {

            }
            Assert.IsNull(laptop);
        }
    }
}
