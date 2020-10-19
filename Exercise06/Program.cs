using System;
using System.Collections.Generic;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Color> colors = new List<Color>();

            colors.Add(new Color() { Name = "Orange", Price = 13.00 });

            Color.PrintList(colors);

            bool inMenu = true;

            do
            {
                Console.WriteLine("Please type a selection: ");
                string selection = Console.ReadLine();
                selection.ToLower();
                if (selection.Equals("add"))
                {
                    Color.Add(colors);
                    bool newMenu = true;
                    do
                    {

                        Console.WriteLine("Would you like to add another color?");
                        string newSelection = Console.ReadLine();
                        newSelection.ToLower();
                        if (newSelection.Equals("no"))
                            newMenu = false;
                        else if (newSelection.Equals("yes"))
                            Color.Add(colors);

                        else
                            Console.WriteLine("That is not a valid selection. Please type 'yes' or 'no'");

                    } while (newMenu);


                }
                else if (selection.Equals("print"))
                    Color.PrintList(colors);
                else if (selection.Equals("clear"))
                    Refresh.refreshPage();
                else if (selection.Equals("total"))
                    Color.Total(colors);
                else if (selection.Equals("exit"))
                {
                    inMenu = false;
                }
                else
                    Console.WriteLine("I don't understand your selection, please try again.");

            } while (inMenu);

        }
    }
}
