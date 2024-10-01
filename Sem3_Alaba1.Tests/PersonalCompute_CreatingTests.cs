﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Alaba1.Tests
{
    [TestClass]
    public class PersonalCompute_CreatingTests
    {
        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, 8, 512)]
        public void Laptop_ShouldCreating(string brand, string model, int year, double price, int ram, int storage)
        {
            try
            {
                Assert.IsNotNull(new PersonalComputer(brand, model, year, price, ram, storage));
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, 512)]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, 512)]
        [DataRow("Undefined", "Undefined", 2000, 1500, -8, -512)]
        public void Laptop_NotShouldCreating(string brand, string model, int year, double price, int ram, int storage)
        {
            PersonalComputer pc = null;
            try
            {
                pc = new PersonalComputer(brand, model, year, price, ram, storage);
            }
            catch
            {

            }
            Assert.IsNull(pc);
        }
    }
}