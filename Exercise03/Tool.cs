using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03
{
    class Tool
    {
        public Tool()
        {
            count++;
        }
        public override string ToString()
        {
            return "ID: " + toolID + "    Tool: " + name;
        }

        private string name;
        private int count;
        private double price;
        private int toolID;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int ToolID
        {
            get { return toolID; }
            set { toolID = value; }
        }
    }
}
