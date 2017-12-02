using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_1
{
    class Program
    {
        static bool alive = true;
        static int drank_coffee = 0;

        static void Main(string[] args)
        {
            while (alive) 
            {
                drink_coffee();
                code();
            }
        }

        private static void drink_coffee()
        {
            int daily_limit = 3 * create_coffee();

            if (drank_coffee > daily_limit)
            {
                Console.WriteLine("Stop drinking coffee!");
                return;
            }

            drank_coffee += create_coffee();
            Console.WriteLine("A programmer is just a tool that converts caffeine into code!");
        }

        private static int create_coffee()
        {
            int coffee = 1;
            int suggar = 2;
            int water = 400;

            Console.WriteLine("Coffee created.");

            return coffee + suggar + water;
        }

        private static void code()
        {
            throw new NotImplementedException();
        }
    }
}
