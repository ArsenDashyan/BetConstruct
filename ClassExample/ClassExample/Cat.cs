using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Cat
    {
        public string Name;
        public double Age;
        public string Color;
        public bool IsMale;

        public Cat(string Name)
        {
            this.Name = Name;
        }

        public Cat(string Name, double Age) :this(Name)
        {
            this.Age = Age;
        }

        public Cat(string Name, double Age, string Color) : this(Name, Age)
        {
            this.Color = Color;
        }

        public Cat(string Name, double Age, string Color, bool IsMale) : this(Name, Age, Color)
        {
            this.IsMale = IsMale;
        }
    }
}
