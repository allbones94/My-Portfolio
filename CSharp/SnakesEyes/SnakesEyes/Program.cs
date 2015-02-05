using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesEyes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int number_of_throws = 0;
            Random rnd1 = new Random();
            
            int dice1;
            int dice2;

            do
            {
                number_of_throws++;

                dice1 = rnd1.Next(1, 7);
                dice2 = rnd1.Next(1, 7);

               

                if (dice1 != dice2)
                {
                    Console.WriteLine("Dice 1: {0}\t Dice 2:{1}", dice1, dice2);
                }
                else
                {
                    Console.WriteLine("Dice 1: {0}\t Dice 2:{1}", dice1, dice2);
                    end = true;
                }

            } while (end == false);

            Console.WriteLine("Well done it took {0} throw(s) to roll a double",number_of_throws);
            Console.ReadLine();
        }
    }
}
