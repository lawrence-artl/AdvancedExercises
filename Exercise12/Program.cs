using System;
using static System.Console;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {

            CursorVisible = false;

            do
            {
                while (!Console.KeyAvailable)
                {
                    WriteLine("O");
                    SetCursorPosition(0, 0);
                    System.Threading.Thread.Sleep(400);
                    WriteLine("X");
                    SetCursorPosition(0, 0);
                    System.Threading.Thread.Sleep(400);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

        }
        

    }
}
