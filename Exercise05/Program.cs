using System;
using System.Collections.Generic;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { Name = "John", Age = 33, Hourly = 11.50 });
            employees.Add(new Employee() { Name = "Angelina", Age = 42, Hourly = 12.30 });
            employees.Add(new Employee() { Name = "Sofia", Age = 16, Hourly = 11.00 });
            employees.Add(new Employee() { Name = "Trinity", Age = 17, Hourly = 11.00 });

            //Employee.PrintList(employees);

            employees.Add(new Employee() { Name = "Lawrence", Age = 37, Hourly = 22.00 });


            Employee.PrintList(employees);

            bool inMenu = true;
            do
            {
                Console.WriteLine("What would you like to do?");
                string selection = Console.ReadLine();
                if (selection.Equals("exit"))
                    inMenu = false;
                else if (selection.Equals("print"))
                    Employee.PrintList(employees);
                else if (selection.Equals("add"))
                    Employee.AddEmployee(employees);

                else
                {
                    Console.WriteLine("That is not a valid selection");
                }
            } while (inMenu);

            Employee.PrintList(employees);

        }
        
    }
}
