using Sem3_Alaba1;
using System.Diagnostics;
using System.Reflection;

namespace Sem3_Alaba1
{
    class Program
    {
        static void PrintDevices(List<ComputerDevice> devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.Info());
            }
        }

        static void Menu()
        {
            List<ComputerDevice> devices = new List<ComputerDevice>();
            int choice = -1;

            do
            {
                Console.WriteLine("Menu:\n" +
                    "1. Add Personal Computer\n" +
                    "2. Add Laptop\n" +
                    "3. Print all devices\n" +
                    "0. Exit\n" +
                    "Enter choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            devices.Add(ComputerDeviceFactory.CreatePersonalComputer());
                            Console.Clear();
                            break;
                        case 2:
                            devices.Add(ComputerDeviceFactory.CreateLaptop());
                            Console.Clear();
                            break;
                        case 3:
                            PrintDevices(devices);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.\n");
                            break;
                    }
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Invalid data. Try again.\n");
                    continue;
                }

            } while (choice != 0);
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
