using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercise04
{
    class PC
    {
        private int count;
        private string name;
        private double price;
        private bool laptop;
        public PC()
        {
            count++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Laptop
        {
            get { return laptop; }
            set { laptop = value; }
        }

        public override string ToString()
        {
            string form = "Yes";            //converts bool to yes or no
            if (laptop == false)
            {
                form = "No";
            }

            return "Name: " + name + "   Price: $" + price + "    Laptop? " + form;
            
        }

    }
}
