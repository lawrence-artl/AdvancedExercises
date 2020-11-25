using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Exercise09
{
    class MainProgram
    {
        public void Start()
        {
            Title = "Menu Demo";
            CursorVisible = false;

            RunMainMenu();

            WriteLine("Press any key to exit.");
            ReadKey(true);
        }
        private void RunMainMenu()
        {
            string title = @"
  _______ _            _____                                     
 |__   __| |          |  __ \                                    
    | |  | |__   ___  | |__) | __ ___   __ _ _ __ __ _ _ __ ___  
    | |  | '_ \ / _ \ |  ___/ '__/ _ \ / _` | '__/ _` | '_ ` _ \ 
    | |  | | | |  __/ | |   | | | (_) | (_| | | | (_| | | | | | |
    |_|  |_| |_|\___| |_|   |_|  \___/ \__, |_|  \__,_|_| |_| |_|
                                        __/ |                    
                                       |___/                     


";
            string prompt = $"{title} Welcome to the Main Menu. Make a selection using the arrow keys.\n";
            string[] options = { "Add", "Remove", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    {
                        RunAddMenu();
                        break;
                    }
                case 1:
                    {
                        RunRemoveMenu();
                        break;
                    }
                case 2:
                    {
                        exitProgram();
                        break;  
                    }
            }
        }

        private void exitProgram()
        {
            WriteLine("\nPress any key to exit the program");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void RunAddMenu()
        {
            string prompt = "Select a person to add:";
            string[] options = { "John", "Bill", "Stacey", "Travis", "Sara" };
            Menu addMenu = new Menu(prompt, options);
            int selectedIndex = addMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    {
                        WriteLine($"You added {options[selectedIndex]}.");
                        break;
                    }
                case 1:
                    {
                        WriteLine($"You added {options[selectedIndex]}.");
                        break;
                    }
                case 2:
                    {
                        WriteLine($"You added {options[selectedIndex]}.");
                        break;
                    }
                case 3:
                    {
                        WriteLine($"You added {options[selectedIndex]}.");
                        break;
                    }
                case 4:
                    {
                        WriteLine($"You added {options[selectedIndex]}.");
                        break;
                    }
            }
            WriteLine("Press any key to continue");
            ReadKey(true);
            RunMainMenu();
        }
        private void RunRemoveMenu()
        {

        }
        
    }

}
