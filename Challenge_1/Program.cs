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

            Console.WriteLine("Ohh, It's zombie! :O");
            Console.ReadKey();
        }

        private static void drink_coffee()
        {
            int daily_limit = 5 * create_coffee();

            if (drank_coffee >= daily_limit)
            {
                Console.WriteLine("Warning: Stop drinking coffee! or die." + Environment.NewLine);
                alive = false;
                return;
            }

            drank_coffee += create_coffee();
            Console.WriteLine("// Nice coffee! A programmer is just a tool " +
                "that converts caffeine into code!");
        }

        private static int create_coffee()
        {
            int coffee = 1;
            int suggar = 2;
            int water = 400;
            
            return coffee + suggar + water;
        }

        private static void code()
        {
            Console.WriteLine(
                "static void Main(string[] args)" + Environment.NewLine +
                "{" + Environment.NewLine +
                    "\tConsole.WriteLine(\"Hello World!\");" + Environment.NewLine +
                "}" + Environment.NewLine + Environment.NewLine);
        }
    }
}
