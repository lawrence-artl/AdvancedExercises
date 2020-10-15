using System;
using System.Collections.Generic;
namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> computers = new List<PC>();
            {
                computers.Add(new PC() { Name = "XPS 9500", Price = 1200.00, Laptop = true });
                computers.Add(new PC() { Name = "Aurora R9", Price = 3700.00, Laptop = false });
                computers.Add(new PC() { Name = "Surface Book 3", Price = 2700.00, Laptop = true });
                computers.Add(new PC() { Name = "XPS 9570", Price = 2600.00, Laptop = true });
            }
            Print(computers);

            static void Print(List<PC> computers)       //generic method to print list, pass list as parameter
            {
                foreach (PC listPC in computers)        //calls ToString method in class PC
                {
                    Console.WriteLine(listPC);
                }
            }

            double newPrice;
            bool form = false;
            Console.WriteLine("Add a new PC\nEnter a name: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter the price: ");
            string intPrice = Console.ReadLine();
            double.TryParse(intPrice, out newPrice);        //parse a double from a string
            
            
            Console.WriteLine("Is this a laptop? y/n");
            string newForm = Console.ReadLine();
            if (newForm.Equals("y") || newForm.Equals("Y"))
                form = true;

            computers.Add(new PC() { Name = newName, Price = newPrice, Laptop = form });

            Print(computers);


        }
    }
}
