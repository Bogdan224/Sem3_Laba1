namespace Sem3_Alaba1
{
    public class ComputerDevice
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
                if(value < 1950) throw new ArgumentException("Wrong argument!");
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
                if(value < 0) throw new ArgumentException("Wrong argument!");
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

        public virtual string Info()
        {
            return $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Price: {Price}$\n";
        }
    };
}

