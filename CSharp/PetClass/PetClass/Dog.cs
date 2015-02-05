using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClass
{
    class Dog: Pet
    {
        public Dog(string name,string color,int numberOfFeet): base(name,color,numberOfFeet)
        {
            Console.WriteLine("My Dog called {0} has {1} legs and {2} fur",base.Name,base.Feet,base.Color);
        }
    }
}
