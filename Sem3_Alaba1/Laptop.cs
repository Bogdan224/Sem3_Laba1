using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Alaba1
{
    internal class Laptop : ComputerDevice {
        private double screenSize;
        public double ScreenSize
        {
            get
            {
                return screenSize;
            }
            set
            {
                if(value < 0) value = 0;
                screenSize = value;
            }
        }
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value < 0) value= 0;
                weight = value;
            }
        }

        public Laptop(string brand = "Unknown", string model = "Unknown", int year = 2000, double price = 0.0, 
            double screenSize = 15.6, double weight = 2.5)
            : base(brand, model, year, price)
        {
            ScreenSize = screenSize;
            Weight = weight;
        }
        public Laptop(ComputerDevice device, double screenSize = 15.6, double weight = 2.5)
            : base(device.Brand, device.Model, device.Year, device.Price)
        {
            ScreenSize = screenSize;
            Weight = weight;
        }

        public override string printInfo()
        {
            return base.printInfo() + $"Screen Size: {ScreenSize} inches\n" +
                $"Weight: {Weight} kg\n";
        }
    }

}
