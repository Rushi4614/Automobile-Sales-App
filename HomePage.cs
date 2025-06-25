using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class HomePage
    {
        public static void AddCar()
        { }
        public static void ViewCars()
        { }
        public static void NewBuyer()
        { }
        public static void ViewSales()
        { }
        public static void Menu()
        {
            int res = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t       Automobile Sales Application");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("1.Add Car  2.View Cars  3.New Buyer  4.View Sales  5.Exit\n\t(Choose any option by using an integer)");
                Console.WriteLine("---------------------------------------------------------");  
                Console.Write("Input: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                { }
                if (input >= 1 && input <= 5)
                {
                    res = 1;
                    switch (input)
                    {
                        case 1:
                            AddCar(); Add.Run();
                            break;
                        case 2:
                            ViewCars();
                            break;
                        case 3:
                            NewBuyer();
                            break;
                        case 4:
                            ViewSales();
                            break;
                        case 5:
                            Console.Clear(); Console.WriteLine("Application is closed...");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please choose again.");
                    Console.ResetColor();   
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
            while (res == 0);
        }
        static void Main(string[] args)
        {
            Menu();
        }

    }
}
