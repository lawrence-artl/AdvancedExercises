using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07
{
    class Refresh
    {
        public static void refreshPage()
        {
            Console.SetCursorPosition(0, Console.WindowTop);
            for (int i = Console.CursorTop; i < Console.WindowHeight; i++)
            {
                Console.Write(new string(' ', Console.WindowWidth)); 
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }
    }
}
