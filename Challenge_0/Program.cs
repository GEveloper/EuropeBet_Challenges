using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool works_in_europebet = true;

            while (works_in_europebet)
            {
                code();
                //sleep();
                eat();
                have_fun();
            }
        }

        private static void code()
        {
            throw new NotImplementedException();
        }

        private static void sleep()
        {
            throw new NotImplementedException();
        }

        private static void eat()
        {
            string[] foods = new string[3] { "apple", "banana", "lobio" };
            Random rnd = new Random();

            foreach (string food in foods)
            {
                int ration = rnd.Next(0, foods.Length);
                food.Take(ration);
            }
        }

        private static void have_fun()
        {
            throw new NotImplementedException();
        }
    }
}
