using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinalSum
{
    class Program
    {
        public static void Main()
        {
            int sum = 0;
            int latest;
            string input;


            // prompt with
            // read-ahead
            Console.WriteLine
            ("next int please?\n"
            + "[-ve to terminate]");

            input = Console.ReadLine();
            latest = int.Parse(input);
            double count = 0;
            double average;
            while (latest > 0)
            {
                count++;
                sum = sum + latest;
                
                // re-prompt
                Console.WriteLine
                ("next int please?\n" +
                 "[-ve to terminate]");
                input =
                Console.ReadLine();
                latest =
                int.Parse(input);
            }average = sum / count;
           
            Console.WriteLine
            ("total = " + sum+"\nAverage = "+average);
            Console.ReadLine();
            
        }

    }
}
