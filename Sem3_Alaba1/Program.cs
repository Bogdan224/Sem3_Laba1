using Sem3_Alaba1;
using System.Diagnostics;
using System.Reflection;

namespace Sem3_Alaba1
{
    class Program
    {
        static ComputerDevice CreateComputerDevice()
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
                throw;
            }
            
        }
        static void AddPersonalComputer(List<ComputerDevice> devices)
        {
            int ram, storage;
            ComputerDevice device = CreateComputerDevice(); 
            try
            {
                               
                Console.WriteLine("Enter RAM: ");
                ram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter storage: ");
                storage = Convert.ToInt32(Console.ReadLine());

                devices.Add(new PersonalComputer(device, ram, storage));
            }
            catch
            {
                throw;
            }


        }

        static void AddLaptop(List<ComputerDevice> devices)
        {
            int screenSize, weight;
            ComputerDevice device = CreateComputerDevice();
            try
            {
                Console.WriteLine("Enter screen size (inches): ");
                screenSize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter weight (kg): ");
                weight = Convert.ToInt32(Console.ReadLine());

                devices.Add(new PersonalComputer(device, screenSize, weight));
            }
            catch
            {
                throw;
            }
              
        }

        static void PrintDevices(List<ComputerDevice> devices)
        {
            foreach (var device in devices)
            {
                device.printInfo();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            ComputerDevice device = new ComputerDevice();
            
            List<ComputerDevice> devices = new List<ComputerDevice>();
            int choice;

            do
            {
                Console.WriteLine("Menu:\n" +
                    "1. Add Personal Computer\n" +
                    "2. Add Laptop\n" +
                    "3. Print all devices\n" +
                    "0. Exit\n" +
                    "Enter choice: ");
                
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPersonalComputer(devices);
                        break;
                    case 2:
                        AddLaptop(devices);
                        break;
                    case 3:
                        PrintDevices(devices);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
