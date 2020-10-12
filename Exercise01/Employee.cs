using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercise01
{
    public class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }       //ensure value is listed second

        }
        private int age;
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private bool directDeposit;
        public bool DirectDeposit
        {
            get { return directDeposit; }
            set { directDeposit = value; }
        }


    }
}
