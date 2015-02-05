using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines;
            Console.Write("Enter number of times I should write: \"I shall not hate C#\" : ");
            
            if(int.TryParse(Console.ReadLine(),out lines)){

                for (int i = 1; i <= lines;i++ )
                {
                    Console.WriteLine("I shall not hate C#");
                }
            }else{
                Console.WriteLine("You didn't enter a number");
            }

            Console.ReadLine();
        }
    }
}
