using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    class Employee
    {
        private string name;
        private int age;
        private double hourly;

        private static int count = 0;

        public Employee()
        {
            count++;
        }
        public static int Count
        {
            get { return count; }
        }

        public string Name
        
            { get; set; }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Hourly
        {
            get { return hourly; }
            set { hourly = value; }
        }

        public static void PrintList(List<Employee> employees)  //needs static keyword to work with program.cs
        {
            Console.WriteLine("{0,-20} {1,5} {2, 11}", "Name", "Hourly", "Age");
            for (int i = 0; i <= count - 1; i++)
            {
                string newName = employees[i].Name;
                double newHourly = employees[i].Hourly;
                int newAge = employees[i].Age;
                
                
                Console.WriteLine("{0,-20} {1,1} {2,5:N2} {3,10}", newName, "$", newHourly, newAge);
            }
        }
        public static void AddEmployee(List<Employee> employees)
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
    }
}
