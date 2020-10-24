using System;
using System.Collections.Generic;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> foods = new List<Food>();

            foods.Add(new Food() { FoodType = "Salad", FoodPrice = 3.50 });
            foods.Add(new Food() { FoodType = "Hamburger", FoodPrice = 4.70 });
            foods.Add(new Food() { FoodType = "Fries", FoodPrice = 2.99 });

            Food.PrintFoodList(foods);

            Console.WriteLine("\nAdd a food item. \nEnter a name: ");
            string newName = Console.ReadLine();
            double newPrice;
            bool enterPrice = true;
            do
            {
                Console.WriteLine("Enter a price for " + newName + ": ");
                //double newPrice = Convert.ToDouble(Console.ReadLine());

                if (!double.TryParse(Console.ReadLine(), out newPrice))
                {
                    Console.WriteLine("That is not a valid price, please try again.");
                }
                else
                    enterPrice = false;
            } while (enterPrice);

            foods.Add(new Food() { FoodType = newName, FoodPrice = newPrice });

            Food.PrintFoodList(foods);
            








        }
    }

    class Food
    {
        private string foodType;
        private double foodPrice;

        public string FoodType
        {
            get { return foodType; }
            set { foodType = value; }
        }
        public double FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; }
        }

        public static void PrintFoodList(List<Food> foods)
        {
            Console.WriteLine("{0,-20} {1,8}", "Food Item", "Price");
            Console.WriteLine(new string('-', 32));
            foreach (var food in foods)
            {
                Console.WriteLine("{0,-20} {1,1} {2,6:N2}", food.FoodType, "$", food.foodPrice);
            }
            
        }

    }


}


