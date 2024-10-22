namespace Sem3_Alaba1
{
    public class Laptop : ComputerDevice {
        private double screenSize;
        public double ScreenSize
        {
            get
            {
                return screenSize;
            }
            set
            {
                if(value < 0) throw new ArgumentException("Wrong argument!");
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
                if(value < 0) throw new ArgumentException("Wrong argument!");
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

        public override string Info()
        {
            return base.Info() + $"Screen Size: {ScreenSize} inches\n" +
                $"Weight: {Weight} kg\n";
        }
    }

}
