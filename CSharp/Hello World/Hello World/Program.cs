using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, welcome to the world",name);
            Console.Read();
        }
    }
}
