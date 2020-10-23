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
            if (count == 0)
            {
                Console.WriteLine("There are no items in the list.");
            }
            else
            {
                Console.WriteLine("{0,-20} {1,7}", "Candy", "Price\n" + new string('-', 28));
                //Console.WriteLine(new string('-', 28));
                for (int i = 0; i <= candies.Count - 1; i++)
                {
                    Console.WriteLine("{0,-20} {1,1} {2,5:N2}", candies[i].Name, "$", candies[i].Price);
                }
                Console.WriteLine();
            }
            

        }
        public static void Add(List<Candy> candies)
        {
            Refresh.refreshPage();
            Console.WriteLine("ADDING AN ITEM\n" + new string('-', 28));
            string newName;
            string strPrice;
            double newPrice;
            Console.Write("Enter a name for the candy: ");
            newName = Console.ReadLine();
            newName.ToLower();
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
                            Console.WriteLine("{0,-20} {1,1} {2,5:N2}", candy.name, "$", candy.price);
                            searchCount++;
                        }
                    }
                    Console.WriteLine();


                    if (searchCount == 0)
                    {
                        Console.WriteLine("That query returned no results.");
                    }
                }
                else if (selection.Equals("p"))
                {
                    Console.Write("Enter the price to search for: ");
                    string strPrice = Console.ReadLine();
                    double newPrice = Double.Parse(strPrice);
                    int searchCount = 0;
                    Console.WriteLine("{0,-20} {1,8}", "\nCandy", "Price");
                    Console.WriteLine(new string('-', 28));

                    foreach (var candy in candies)                  //use a foreach loop here instead of a for loop (issues with index values)
                    {
                        double queryPrice = candy.price;
                        if (newPrice.Equals(queryPrice))
                        {
                            Console.WriteLine("{0,-20} {1,1} {2,5:N2}", candy.name, "$", candy.price);
                            searchCount++;
                        }
                    }
                    Console.WriteLine();


                    if (searchCount == 0)
                    {
                        Console.WriteLine("That query returned no results.");
                    }
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
            Refresh.refreshPage();
            Console.WriteLine("REMOVING AN ITEM\n" + new string('-', 28));
            bool newRemove = true;
            PrintList(candies);
            do
            {
                int[] indexsToRemove = new int[10];
                int i = 0;

                Console.WriteLine("Remove an item from the list\nType the name of the item to remove: ");
                string selection = Console.ReadLine();
                if (selection.Equals("exit"))
                {
                    newRemove = false;
                }
                else if (selection.Equals("clear"))
                    Refresh.refreshPage();
                else if (selection.Equals("print"))
                    PrintList(candies);
                else
                {
                    selection.ToLower();
                    int j = 0;                          //index counter
                    foreach (var candy in candies)      //move through candies one at a time
                    {
                        if (selection.Equals(candy.name.ToLower()))         //if the candy matches the query
                        {
                            indexsToRemove[i] = j;      //...add it's list index to the array of indexes
                            i++;                        //move to the next index in array
                        }
                        j++;                            //regardless, increase index counter by 1
                    }
                    //i--;
                    if (i >= 1)                         //even if only one item is found, i should be greater than zero
                    {
                        Console.WriteLine("Remove this item:");
                        for (int k = 0; k < i; k++)     //i is the number of indexes we got to in array
                        {

                            Console.WriteLine(candies[indexsToRemove[k]].name);     //move through array one index at a time
                        }
                        Console.WriteLine("Type 'yes' to confirm (this cannot be undone) ");
                        string confirm = Console.ReadLine();
                        if (confirm.ToLower().Equals("yes"))
                        {
                            //i--;
                            int k = i - 1;
                            do
                            {
                                candies.RemoveAt(indexsToRemove[k]);
                                k--;
                                count--;
                            } while (k >= 0);
                        }
                        else
                        {

                        }
                    }
                    else
                        Console.WriteLine("There was no matches for that search");


                }


            } while (newRemove);
        }
    }
}
