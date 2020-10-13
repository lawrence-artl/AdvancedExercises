using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    class Pet
    {
        public static int count = 0;
        public Pet()
        {
            count++;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        private int num;
        public int Num
        {
            get { return num; }
            set { num = count; }

        }



    }
}
