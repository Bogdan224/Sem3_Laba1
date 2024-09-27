using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Alaba1
{
    internal class ComputerDevice
    {

        public string Brand {  get; set; }
        public string Model { get; set; }

        private int year;
        public int Year {
            get
            {
                return year;
            }
            set
            {
                if(value < 2000) value = 2000;
                year = value;
            }
        }
        private double price;
        public double Price {
            get
            {
                return price;
            }
            set
            {
                if(price < 0) value = 0;
                price = value;
            }
        }

        public ComputerDevice(string brand = "Unknown", string model = "Unknown", int year = 2000, double price = 0.0)
        {

            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public virtual string printInfo()
        {
            return $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Price: {Price}$\n";
        }
    };
}

