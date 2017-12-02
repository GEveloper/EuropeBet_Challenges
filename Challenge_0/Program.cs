using System;
using System.Linq;

namespace Challenge_0
{
    class Program
    {
        static bool works_in_europebet = true;
        static int fun = 0;
        static int fun_limit = 2017;

        static void Main(string[] args)
        {
            while (works_in_europebet)
            {
                Code();
                //Sleep();
                Eat();
                HaveFun();
            }

            Console.WriteLine("You are not working in EuropeBet, anymore.");
            Console.ReadKey();
        }

        private static void Code()
        {
            Console.WriteLine("Console.WriteLine(\"Hello World\");");
        }

        private static void Sleep()
        {
            System.Threading.Thread.Sleep(8 * 60 * 60 * 1000);
        }

        private static void Eat()
        {
            string[] foods = new string[3] { "apple", "banana", "lobio" };
            Random rnd = new Random();

            foreach (string food in foods)
            {
                int ration = rnd.Next(0, foods.Length);
                food.Take(ration);
            }
        }

        private static void HaveFun()
        {
            Console.WriteLine("life is awesome!");

            if (++fun > fun_limit) // too much fun!
            {
                works_in_europebet = false;
            }
        }
    }
}
