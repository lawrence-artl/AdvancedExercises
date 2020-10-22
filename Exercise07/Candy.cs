using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07
{
    class Candy
    {
        private string name;
        private double price;
        public static int count = 0;
        public static int index = -1;

        public Candy()
        {
            count++;
            index++;

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
            if (count == 0)
            {
                Console.WriteLine("There are no items in the list.");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,7}", "Candy", "Price");
                Console.WriteLine(new string('-', 28));
                for (int i = 0; i <= candies.Count - 1; i++)
                {
                    Console.WriteLine("{0,-20} {1,1} {2,5:N2}", candies[i].Name, "$", candies[i].Price);
                }
            }
            

        }
        public static void Add(List<Candy> candies)
        {
            string newName;
            string strPrice;
            double newPrice;
            Console.Write("Enter a name for the candy: ");
            newName = Console.ReadLine();
            newName = char.ToUpper(newName[0]) + newName.Substring(1);      //capitalize first letter of name
            Console.Write("Enter the price for " + newName + ": ");
            strPrice = Console.ReadLine();
            newPrice = Double.Parse(strPrice);
            candies.Add(new Candy() { Name = newName, Price = newPrice });

        }
        public static void Search(List<Candy> candies)
        {
            bool newSearch = true;
            do
            {
                Console.Write("Search by 'name' or by 'price'? ");
                string selection = Console.ReadLine();
                selection.ToLower();
                selection = selection.Substring(0, 1);
                if (selection.Equals("n"))
                {
                    List<Candy> searchCandy = new List<Candy>();
                    searchCandy.Add(new Candy() { Name = "null", Price = 0.00 });
                    Console.Write("Enter the name to search for: ");
                    string newName = Console.ReadLine();
                    newName = newName.ToLower();
                    int searchCount = 0;

                    Console.WriteLine("{0,-20} {1,8}", "\nCandy", "Price");
                    Console.WriteLine(new string('-', 28));

                    foreach (var candy in candies)                  //use a foreach loop here instead of a for loop (issues with index values)
                    {
                        string queryName = candy.name.ToLower();
                        if (newName.Equals(queryName))
                        {
                            Console.WriteLine("{0,-20} {1,1} {1,5:N2}", candy.name, "$", candy.price);
                            searchCount++;
                        }
                    }
                    Console.WriteLine();


                    if (searchCount == 0)
                    {
                        Console.WriteLine("That query returned no results.");
                        Console.ReadLine();

                    }
                }
                else if (selection.Equals("p"))
                {

                }
                else if (selection.Equals("e"))
                    newSearch = false;
                else if (selection.Equals("c"))
                    Refresh.refreshPage();
                else
                    Console.WriteLine("That is not a valid selection; please type 'name' or 'price' or 'exit' " + selection);
               
            } while (newSearch);
        }
        public static void Sort(List<Candy> candies)
        {

        }
        public static void Remove(List<Candy> candies)
        {

        }
    }
}
