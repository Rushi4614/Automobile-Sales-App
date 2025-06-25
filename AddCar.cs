using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Add
    {
        public static void Run()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter Car Details: ");
            Console.ResetColor();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Company Name: ");
            Console.WriteLine("Model Name: ");
            Console.WriteLine("Model Number: ");
            Console.WriteLine("Color: ");
            Console.WriteLine("Price: ");
        }
    }
}
