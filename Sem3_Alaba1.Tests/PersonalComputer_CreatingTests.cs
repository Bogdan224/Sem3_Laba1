using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Alaba1.Tests
{
    [TestClass]
    public class PersonalComputer_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, 8, 512)]
        public void PersonalComputer_ShouldCreating(string brand, string model, int year, double price, int ram, int storage)
        {

            Assert.IsNotNull(new PersonalComputer(brand, model, year, price, ram, storage));

        }

        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, 512)]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, 512)]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, -512)]
        public void PersonalComputer_NotShouldCreating(string brand, string model, int year, double price, int ram, int storage)
        {
            Assert.ThrowsException<ArgumentException>(()=> new PersonalComputer(brand, model, year, price, ram, storage));
        }
    }
}
