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
                Console.WriteLine("Add a new employee? y/n");
                string selection = Console.ReadLine();
                if (selection.Equals("n"))
                    inMenu = false;
                else if (selection.Equals("print"))
                    Employee.PrintList(employees);
                else
                {
                    Console.WriteLine("Enter a name: ");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter their age: ");
                    string strAge = Console.ReadLine();
                    int newAge = Int32.Parse(strAge);
                    Console.WriteLine("Enter their hourly rate: ");
                    string strHourly = Console.ReadLine();
                    double newHourly = Double.Parse(strHourly);

                    employees.Add(new Employee() { Name = newName, Age = newAge, Hourly = newHourly });

                    Console.WriteLine("Employee " + employees[Employee.Count - 1].Name + " added.");
                }
            } while (inMenu);

            Employee.PrintList(employees);

        }
        
    }
}
