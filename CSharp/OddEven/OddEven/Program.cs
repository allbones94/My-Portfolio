using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool end = false;
            do
            {
                Console.WriteLine("Odd or Even? Type non numeric value to finish");

                if (int.TryParse(Console.ReadLine(), out number))
                {

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("\n{0} is Even\n", number);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} is Odd\n", number);
                    }
                }
                else
                {
                    end = true;
                }
                

            } while (end == false); 
        }
    }
}
