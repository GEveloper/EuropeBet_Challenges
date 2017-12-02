using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_1
{
    class Program
    {
        static bool alive = true;

        static void Main(string[] args)
        {
            while (alive) 
            {
                drink_coffee();
                code();
            }
        }

        private static void code()
        {
            throw new NotImplementedException();
        }

        private static void drink_coffee()
        {
            throw new NotImplementedException();
        }
    }
}
