using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;


//text file data access demo

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\dayar\Desktop\names.txt";

            //List <string> lines = File.ReadAllLines(filePath).ToList();     //need System.Linq for this command

            //foreach (string line in lines)
            //{
            //    WriteLine(line);
            //}

            //lines.Add("Sofia,Day,16");

            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                if (line.Contains(',') == false)
                {
                    continue;
                }

                Person newPerson = new Person();
                
                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Age = Int32.Parse(entries[2]);

                people.Add(newPerson);
            }

            foreach(var person in people)
            {
                WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
            }

            people.Add(new Person() { FirstName = "Smoke", LastName = "Cat", Age = 13 });
            
            
            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Age}");

            }
            File.WriteAllLines(filePath, output);


            
            ConsoleKey keyPressed;
            WriteLine("Press Enter to exit");

            //ReadKey(true);
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                
            } while (keyPressed != ConsoleKey.Enter);
            
                
            Environment.Exit(0);
        }
    }
}
