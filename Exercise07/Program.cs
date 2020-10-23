using System;
using System.Collections.Generic;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candy> candies = new List<Candy>();

            candies.Add(new Candy() { Name = "Snickers", Price = 4.00 });
            candies.Add(new Candy() { Name = "Skittles", Price = 5.50 });
            candies.Add(new Candy() { Name = "Twix", Price = 7.30 });

            Candy.PrintList(candies);

            bool inMenu = true;
            do
            {
                Console.WriteLine("Type your selection");
                string selection = Console.ReadLine();
                selection.ToLower();
                selection.Trim();
                if (selection.Equals("print"))
                {
                    Candy.PrintList(candies);
                }
                else if (selection.Equals("add"))
                {
                    Candy.Add(candies);
                    bool addMore = true;
                    do
                    {
                        Console.Write("Would you like to add another? yes/no ");
                        string newSelection = Console.ReadLine();
                        newSelection.ToLower();
                        newSelection.Trim();
                        newSelection.Substring(0, 1);
                        if (newSelection.StartsWith("n"))
                        {
                            addMore = false;
                        }
                        else if (newSelection.StartsWith("y"))
                        {
                            Candy.Add(candies);
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid selection; type 'yes' or 'no' ");
                        }
                    } while (addMore);
                }
                else if (selection.Equals("exit"))
                {
                    inMenu = false;
                }
                else if (selection.Equals("help"))
                {
                    Refresh.refreshPage();
                    Console.WriteLine("Menu Options:\n'Add'\n'Print'\n'Help'\n'Clear'\n'Search'\n'Remove'\n'Exit'\n\n" +
                        "Press any key to clear and continue.");
                    Console.ReadKey();
                    Refresh.refreshPage();
                }
                else if (selection.Equals("clear"))
                {
                    Refresh.refreshPage();
                }
                else if (selection.Equals("search"))
                {
                    Candy.Search(candies);
                }
                else if (selection.Equals("remove"))
                {
                    Candy.Remove(candies);
                }
                else
                {
                    Console.WriteLine("That was not a valid selection, please try again.");
                }
                
            } while (inMenu);
        }
    }
}
