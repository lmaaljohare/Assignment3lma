using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Model
{
    class User
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "ID:" + ID + ", " + "Name: " + Name + ", " + "Age: " + Age;
        }


    }
}
