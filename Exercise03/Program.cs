using System;
using System.Collections.Generic;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tool> tools = new List<Tool>();

            tools.Add(new Tool() { Name = "hammer", ToolID = 1334 });
            tools.Add(new Tool() { Name = "screwdriver", ToolID = 4355 });
            tools.Add(new Tool() { Name = "wrench", ToolID = 5344 });

            Console.WriteLine();
            foreach (Tool listTool in tools)
            {
                Console.WriteLine(listTool);
            }




            /*
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            */




        }
    }
}
