namespace Sem3_Alaba1
{
    public static class ComputerDeviceFactory
    {
        private static ComputerDevice CreateComputerDevice()
        {
            string brand, model;
            int year;
            double price;
            try
            {
                Console.WriteLine("Enter brand: ");
                brand = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                model = Console.ReadLine();
                Console.WriteLine("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter price: ");
                price = Convert.ToInt32(Console.ReadLine());

                return new ComputerDevice(brand, model, year, price);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }
        }
        public static PersonalComputer CreatePersonalComputer()
        { 
            int ram, storage;
            ComputerDevice device = CreateComputerDevice();
            try
            {
                Console.WriteLine("Enter RAM: ");
                ram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter storage: ");
                storage = Convert.ToInt32(Console.ReadLine());

                return new PersonalComputer(device, ram, storage);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }


        }

        public static Laptop CreateLaptop()
        {
            double screenSize, weight;
            ComputerDevice device = CreateComputerDevice();
            try
            {
                Console.WriteLine("Enter screen size (inches): ");
                screenSize = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter weight (kg): ");
                weight = Convert.ToDouble(Console.ReadLine());

                return new Laptop(device, screenSize, weight);
            }
            catch
            {
                throw new ArgumentException("Wrong argument!");
            }

        }
    }
}
