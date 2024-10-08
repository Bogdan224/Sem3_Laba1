﻿namespace Sem3_Alaba1
{
    public class PersonalComputer : ComputerDevice
    {
        private int ram;
        public int Ram
        {
            get
            {
                return ram;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Wrong argument!"); ;
                ram = value;
            }
        }
        private int storage;
        public int Storage
        {
            get
            {
                return storage;
            }
            set
            {
                if(value < 0) throw new ArgumentException("Wrong argument!"); ;
                storage = value;
            }
        }
        public PersonalComputer(string brand = "Unknown", string model = "Unknown", int year = 2000, 
            double price = 0.0, int ram = 8, int storage = 256)
            : base(brand, model, year, price)
        {
            Ram = ram;
            Storage = storage;
        }

        public PersonalComputer(ComputerDevice device, int ram = 8, int storage = 256)
            : base(device.Brand, device.Model, device.Year, device.Price)
        {
            Ram = ram;
            Storage = storage;
        }

        public override string Info() 
        {
            return base.Info() + $"Ram: {Ram} GB\n" +
                $"Storage: {Storage} GB\n";
        }

    }
}
