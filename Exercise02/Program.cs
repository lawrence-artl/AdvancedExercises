using System;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet cat = new Pet();
            Pet dog = new Pet();

            cat.Name = "Smoke";
            cat.Age = 13;

            dog.Name = "Barky";
            dog.Age = 10;

            Console.WriteLine("There are " + Pet.count + " pets here.");

            Pet hamster = new Pet();
            hamster.Name = "Herman";
            hamster.Age = 5;
            hamster.Num = Pet.count;

            Console.WriteLine("There are " + Pet.count + " pets here now.");

            Console.WriteLine("The cat's name is " + cat.Name);
            Console.WriteLine("The pet at position " + hamster.Num + " is named " + hamster.Name);
            

        
        }
    }
}
