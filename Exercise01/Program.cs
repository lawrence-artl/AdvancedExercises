using System;
using System.Collections.Generic;   //for Lists

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name for an employee:");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter the employee's age:");
            string Agestr = Console.ReadLine();
            Console.WriteLine("Did the employee apply for Direct Deposit?");
            string DirectD = Console.ReadLine();

            int AgeNum = Int32.Parse(Agestr);
            bool dd;
            DirectD.ToLower();
            if (DirectD.Equals("yes") || DirectD.Equals("y"))
            {
                dd = true;
            }
            else
                dd = false;
            Console.WriteLine(newName);

            List <Employee> employee = new List <Employee>();

            employee.Add(new Employee() { Name = newName, Age = AgeNum, DirectDeposit = dd });

            /*
            employee.Name = newName;
            employee.Age = AgeNum;
            employee.DirectDeposit = dd;
            */

            Console.WriteLine("\nThe Employee entered is:");
            Console.WriteLine("The employee's name is: " + employee[0].Name);   
            Console.WriteLine("The employee's age is " + employee[0].Age);
            Console.WriteLine("The employee has signed up for direct deposit? " + employee[0].DirectDeposit);





        }
    }
}
