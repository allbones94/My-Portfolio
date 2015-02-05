using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClass
{
    class Pet
    {
        
        string name;
        int numberOfFeet;
        string color;

        public Pet(string name,string color,int numberOfFeet)
        {
            this.name = name;
            this.color = color;
            this.numberOfFeet = numberOfFeet;
        }

        public string Name
        {
            get { return name; }
            set{this.name = value;}
        }

        public string Feet
        {
            get { return numberOfFeet.ToString(); }
            
        }

        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }
    }
}
