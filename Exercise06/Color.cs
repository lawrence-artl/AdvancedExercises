using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Color
    {
        private string name = "white";
        private double price = 1.00;
        private static int count;

        public Color()
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

        public static void PrintList(List<Color> colors)
        {
            Console.WriteLine("{0,-15} {1,6}", "Name", "Price");
            Console.WriteLine(new string ('-', 22));

            for (int i = 0; i <= count-1; i++)
            {
                Console.WriteLine("{0,-15} {1,6:N2}", colors[i].name, colors[i].price);
            }
            Console.WriteLine();
        }
        public static void Add(List<Color> colors)
        {
            string newName;
            string strPrice;
            double newPrice;
            Console.WriteLine("Enter the name of a color: ");
            newName = Console.ReadLine();
            Console.WriteLine("Enter the price of the color: ");
            strPrice = Console.ReadLine();
            newPrice = Double.Parse(strPrice);

            colors.Add(new Color() { Name = newName, Price = newPrice });
        }

        public static void Total(List<Color> colors)
        {
            double newTotal = 0;

            for (int i = 0; i <= count - 1; i++)
            {
                newTotal = newTotal + colors[i].Price;
            }
            Console.WriteLine("{0,-15} {1,6:N2}", "Total", newTotal);
        }
    }

}
