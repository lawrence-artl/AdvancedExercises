using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07
{
    class Candy
    {
        private string name;
        private double price;
        public static int count;

        public Candy()
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
        public static void PrintList(List<Candy> candies)
        {
            Console.WriteLine("{0,-20} {1,7}", "Candy", "Price");
            Console.WriteLine(new string('-', 28));
            for (int i = 0; i <= count - 1; i++)
            {
                Console.WriteLine("{0,-20} {1,1} {2,5:N2}", candies[i].Name, "$", candies[i].Price);
            }

        }
        public static void Add(List<Candy> candies)
        {
            string newName;
            string strPrice;
            double newPrice;
            Console.Write("Enter a name for the candy: ");
            newName = Console.ReadLine();
            Console.Write("Enter the price for " + newName + ": ");
            strPrice = Console.ReadLine();
            newPrice = Double.Parse(strPrice);
            candies.Add(new Candy() { Name = newName, Price = newPrice });

        }
        public static void Search(List<Candy> candies)
        {

        }
        public static void Sort(List<Candy> candies)
        {

        }
        public static void Remove(List<Candy> candies)
        {

        }
    }
}
