using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        public static void Main()
        {
            int n;  // size of triangle/
            string input;

            // Prompt for
            // triangle size.
            Console.Write
            ("Triangle size?\n");
            input =
            Console.ReadLine();
            n = int.Parse(input);

            Console.WriteLine();
            for (int i = 1; n >= i; n--)
            {
                string stars = ""; // throw three spaces
                
                // print i asterisks
                for (int j = 1; j <= n; j++)
                {
                    stars += "*  ";
                }
            
                Console.WriteLine(stars);
                
            }Console.ReadLine();
        }
    }
}
