using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Sem3_Alaba1.Tests
{
    [TestClass]
    public class ComputerDevice_CreatingTests
    {

        [TestMethod]
        [DataRow("Undefined", "Undefined", 2000, 1500)]
        public void ComputerDevice_ShouldCreating(string brand, string model, int year, double price)
        {
            Assert.IsNotNull(new ComputerDevice(brand, model, year, price));
           
        }

        [TestMethod]
        [DataRow("undefined", "Undefined", 1899, 1500)]
        [DataRow("undefined", "Undefined", 2000, -122)]
        [DataRow(null, null, null, null)]
        public void ComputerDevice_NotShouldCreating(string brand, string model, int year, double price)
        {
            Assert.ThrowsException<ArgumentException>(() => new ComputerDevice(brand, model, year, price));
            
        }
    }
}
